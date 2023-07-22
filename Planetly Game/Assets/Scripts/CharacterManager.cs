using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Music {A,B,C,D,E,F,G }

public class CharacterManager : MonoBehaviour
{

    // enums
    private enum MotionState { Walk, Run, Cooldown };

    //input system
    private InputManager controls;

    // general variables
    [SerializeReference] private Transform mCharacterTransform;
    [SerializeReference] private CharacterController mCharacterController;
    [SerializeReference] private Rigidbody mRigidbody;
    public static CharacterManager current;
    [SerializeReference] private Camera mMainCamera;
    [SerializeReference] private CinemachineFreeLook mCinemachine;
    public Animator mAnimator;
    public bool parkur = false;
    // character controls
    [SerializeReference] private Canvas Helper;
    public event Action<Music> onPressMusicKey;
    
    
    // gravity system
    private bool isGrounded = false;
    private float lastGround;
    private readonly float gravity = -9.97f;
    float velocityY;

    // movement and rotation related variables
    [SerializeReference] private float walkingSpeed;
    [SerializeReference] private float runningSpeed;
    private MotionState _motionState;
    private float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    private float jumpForce = 10f;

    // cooldown
    private float TotalStamina = 5f; //stamina
    private float _currentStamina;
    
    // music
    [SerializeField] private List<AudioClip> sounds;

    
    void Awake()
    {
        controls = new InputManager();
        current = this;
    }
    
    void Start()
    {
        _currentStamina = TotalStamina;
        _motionState = MotionState.Walk;
        velocityY = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameMode();
        FastReset();
    }

    private void GameMode()
    {
        ShowHelper();
        Movement();
        playsound();
        Cooldown();
        if (!(controls.Player.CameraControl.ReadValue<Vector2>().ToString()).Equals(Vector2.zero))
        {
            Debug.Log((controls.Player.CameraControl.ReadValue<Vector2>().ToString()));
        }

        if (HitInput())
        {
            Debug.Log("working");
        }
        
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    /*****************************************  Cooldown  *****************************************/
    private void Cooldown()
    {
        StaminaCooldown();
    }

    private void StaminaCooldown()
    {
        if ((_currentStamina <= 0f) || _motionState.Equals(MotionState.Cooldown))
        {
            // audio: inhaling
            if (!_motionState.Equals(MotionState.Cooldown))
            {
                ChangeMotionStage(MotionState.Cooldown);
            }
        }

        if (_currentStamina <= TotalStamina)
        {
            AddStamina(Time.deltaTime);
            if (_currentStamina > TotalStamina)
            {
                _currentStamina = TotalStamina;
                ChangeMotionStage(MotionState.Walk);
            }
        }
    }

    /*****************************************  Movement  *****************************************/
    
    private void Movement()
    {
        Vector3 direction = MovementDirection(controls.Player.Movement.ReadValue<Vector2>());
        float speed = walkingSpeed;
        if (!direction.Equals(Vector3.zero))
        {
            switch (_motionState)
            {
                case MotionState.Walk:
                    if (CanRun())
                    {
                        ChangeMotionStage(MotionState.Run);
                        speed = Run();
                    }
                    else
                    {
                        speed = Walk();
                    }
                    break;
            
                case MotionState.Run:
                    speed = Run();
                    break;
            
                default:
                    speed = Walk();
                    break;
            }
        }
        else
        {
            mAnimator.SetFloat("speed", 0);
            return;
        }
        Vector3 characterVelocity = Vector3.zero;
        if (direction.magnitude > 0.1f)
        {
            Vector3 moveDir = RotateCharacter(direction).normalized;
            characterVelocity = moveDir * speed;
        }

        VerticalMovement();
        characterVelocity.y = velocityY;
        //Debug.Log(characterVelocity * Time.deltaTime);
        MoveCharacter(characterVelocity * Time.deltaTime);
        mAnimator.SetFloat("speed", speed);
    }

    private void VerticalMovement()
    {
        if ((CanJump()) || (!mCharacterController.isGrounded))
        {
            if (CanJump())
            {
                velocityY = jumpForce;
                ReduceStamina(2f);
            }
            if (velocityY > 0)
            {
                velocityY += 2.5f* gravity * Time.deltaTime;
            }
            else
            {
                velocityY += 7f* gravity * Time.deltaTime;
            }
        }
        else
        {
            velocityY = 0f;
        }

    }
    
    private void Idle()
    {
        // animation: idle
        // state machine for inhaling
        return;
    }
    
    private float Walk()
    {
        // animation: walking
        float speed = walkingSpeed;
        return speed;
    }
    
    private float Run()
    {
        float speed = runningSpeed;
        // animation: running
        
        if (CanRun())
        {
            ReduceStamina(Time.deltaTime);
        }
        else
        {
            ChangeMotionStage(MotionState.Cooldown);
            speed = walkingSpeed;
        }
        return speed;
    }

    /**
     * Move the character around
     */
    private void MoveCharacter(Vector3 movement)
    {
        mCharacterController.Move(movement);
    }
    
    /**
     * Returns the movement direction
     */
    private Vector3 MovementDirection(Vector2 input)
    {
        Vector3 forward = ForwardDirection();
        Vector3 right = RightDirection();
        // trigonometric movement
        Vector3 direction = input.y * forward + input.x * right; 
        //Vector3(input.x, 0, input.y);
        if (direction.magnitude < 0.1f)
        {
            return Vector3.zero;
        }
        return direction.normalized;
    }

    /**
     * Rotate the character
     */
    private Vector3 RotateCharacter(Vector3 direction)
    {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0, angle, 0);

        return Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
    }

    public void Teleport(Vector3 location)
    {
        Debug.Log("teleporting to"+location);
        mCharacterController.enabled = false;
        transform.position = location;
        mCharacterController.enabled = true;
    }

    /*****************************************  Utils  *****************************************/

    /**
     *  Returns the forward direction for movement utilities
     */
    private Vector3 ForwardDirection()
    {
        Vector3 objectiveForward = mMainCamera.transform.forward;
        //Vector3 objectiveForward = transform.forward;
        return new Vector3(objectiveForward.x, 0f, objectiveForward.z).normalized;
    }
    
    /**
     *  Returns the right direction for movement utilities
     */
    private Vector3 RightDirection()
    {
        Vector3 objectiveRight = mMainCamera.transform.right;
        //Vector3 objectiveRight = transform.right;
        return new Vector3(objectiveRight.x, 0f, objectiveRight.z).normalized;
    }
    
    /**
     * Declare motion change
     */
    private void ChangeMotionStage(MotionState motionState)
    {
        _motionState = motionState;
    }

    /**
     * Reducing Stamina 
     */
    private void ReduceStamina(float x)
    {
        if (!parkur)
        {
            _currentStamina -= x;
        }
    }

    /**
     * Add stamina
     */
    private void AddStamina(float x)
    {
        _currentStamina += x;
    }

    /**
     * can the player run based on stamina and input
     */
    private bool CanRun()
    {
        return (IsRunningInput() && (_currentStamina > 0f));
    }
    
    /**
     * can the player jump based on stamina, position and input
     */
    private bool CanJump()
    {
        return (IsJumpingInput() && (!_motionState.Equals(MotionState.Cooldown)) && mCharacterController.isGrounded);
    }
    
    public void PressMusicKey(Music key)
    {
        
        if (onPressMusicKey != null)
        {
            //Debug.Log(key + " AT:" + Time.time);
            onPressMusicKey(key);
        }
    }

    /***************************************** Input Integrations *****************************************/

    /**
     * Returns if the player wishes to run
     */
    private bool IsRunningInput()
    {
        return (controls.Player.Run.ReadValue<float>() >= 0.1f);
    }
    
    /**
     * Returns if the player wishes to jump
     */
    private bool IsJumpingInput()
    {
        return (controls.Player.Jump.ReadValue<float>() >= 0.1f);
    }

    private bool EatInput()
    {
        return (controls.Player.Eat.ReadValue<float>() >= 0.1f); 
    }
    
    private bool HitInput()
    {
        return (controls.Player.Hit.ReadValue<float>() >= 0.1f); 
    }

    private void ShowHelper()
    {
        //Helper.enabled = ((controls.Player.Info.ReadValue<float>() >= 0.1f));
    }

    public void changeColor(Color color)
    {
        transform.GetComponent<Material>().color = color;
    }

    
    //temp code for the showcase
    public void playsound()
    {
        if (controls.Music.A.triggered)
        {
            AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = sounds[0];
            //audio.Play();
            PressMusicKey(Music.A);
        }
        if (controls.Music.B.triggered)
        {
            AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = sounds[1];
            //audio.Play();
            PressMusicKey(Music.B);
        }
        if (controls.Music.C.triggered)
        {
            AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = sounds[2];
            //audio.Play();
            PressMusicKey(Music.C);
        }
        
        if (controls.Music.D.triggered)
        {
            AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = sounds[3];
            //audio.Play();
            PressMusicKey(Music.D);
        }
    }
    
    public void FastReset()
    {
        if((controls.Screens.FastReset.ReadValue<float>()) >= 0.1f)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
