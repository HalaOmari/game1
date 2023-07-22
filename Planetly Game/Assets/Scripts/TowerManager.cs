using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] teleports;
    [SerializeField] private GameObject[] enteries;
    [SerializeField] private GameObject player;
    private int curr = 0;
    private Dictionary<GameObject, GameObject>[] Courses;
    private InputManager controls;
    [SerializeField] private Material[] materials;
    private bool pressed = true;

    void Awake()
    {
        controls = new InputManager();
    }
    void Start()
    {
        Courses = new Dictionary<GameObject, GameObject>[]
        {
            new Dictionary<GameObject, GameObject>(),
            new Dictionary<GameObject, GameObject>(),
            new Dictionary<GameObject, GameObject>(),
        };
        makeCourses();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (controls.CastleRiddle.Change.ReadValue<float>() >= 0.1f)
        { 
            if (pressed) 
            { 
                curr = (curr + 1) % 3; 
                Debug.Log("change "+curr);
                player.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material = materials[curr];
                pressed = false;
            }
        }
        else 
        { 
            if (pressed == false) 
            { 
                pressed = true;
            }
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
    
    private void makeCourses()
    {
        // First Course
        Courses[0].Add(teleports[0], teleports[6]);
        Courses[0].Add(teleports[1], teleports[0]);
        Courses[0].Add(teleports[2], teleports[5]);
        Courses[0].Add(teleports[3], teleports[8]);
        Courses[0].Add(teleports[4], teleports[7]);
        Courses[0].Add(teleports[5], teleports[7]);
        Courses[0].Add(teleports[6], teleports[1]);
        Courses[0].Add(teleports[7], teleports[6]);
        Courses[0].Add(teleports[8], teleports[8]);
        
        Courses[0].Add(enteries[0], teleports[0]);
        Courses[0].Add(enteries[1], teleports[1]);
        
        
        // Second Course
        Courses[1].Add(teleports[0], teleports[1]);
        Courses[1].Add(teleports[1], teleports[6]);
        Courses[1].Add(teleports[2], teleports[6]);
        Courses[1].Add(teleports[3], teleports[1]);
        Courses[1].Add(teleports[4], teleports[1]);
        Courses[1].Add(teleports[5], teleports[1]);
        Courses[1].Add(teleports[6], teleports[5]);
        Courses[1].Add(teleports[7], teleports[4]);
        Courses[1].Add(teleports[8], teleports[8]);
        
        Courses[1].Add(enteries[0], teleports[0]);
        Courses[1].Add(enteries[1], teleports[1]);
        
        
        // Third Course
        Courses[2].Add(teleports[0], teleports[1]);
        Courses[2].Add(teleports[1], teleports[0]);
        Courses[2].Add(teleports[2], teleports[0]);
        Courses[2].Add(teleports[3], teleports[5]);
        Courses[2].Add(teleports[4], teleports[2]);
        Courses[2].Add(teleports[5], teleports[1]);
        Courses[2].Add(teleports[6], teleports[0]);
        Courses[2].Add(teleports[7], teleports[1]);
        Courses[2].Add(teleports[8], teleports[8]);
        
        Courses[2].Add(enteries[0], teleports[0]);
        Courses[2].Add(enteries[1], teleports[1]);
    }

    public GameObject getTeleportDestination(GameObject teleport)
    {
        return Courses[curr][teleport];
    }
}
