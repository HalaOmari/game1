using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onetabErr : TypeErr
{

    
    [SerializeField] private GameObject pos1;
    [SerializeField] private GameObject pos2;
    [SerializeField] private GameObject platform;
    [SerializeField] private float speed;
    private GameObject dest;

    private void Start()
    {
        if (pos1)
        {
            dest = pos1;
        }
    }

    //add to only refer to player
    protected override void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (active && other.CompareTag("Player"))
        {
            Debug.Log("active");
            CharacterManager.current.onPressMusicKey += TrySolve;
        }
    }

    //add to only refer to player
    protected override void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterManager.current.onPressMusicKey -= TrySolve;
            ExitSolveArea();
            Debug.Log("deactive");   
        }
    }

    void FixedUpdate()
    {
        // Calculate direction vector
        Vector3 dir = platform.transform.position - dest.transform.position;
        // Normalize resultant vector to unit Vector
        if (dir.magnitude > 0.05)
        {
            dir = -dir.normalized;
            // Move in the direction of the direction vector every frame 
            platform.transform.position += dir * Time.deltaTime * speed;
        }
    }
    

    /**
     * Try solving function.
     */
    public override void TrySolve(Music key)
    {
        if (key == Music.A)
        {
            dest = pos1;
        }
        else
        {
            if(key == Music.B)
            {
                dest = pos2;
            }
        }
    }
}
