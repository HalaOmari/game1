using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEnterErr : TypeErr
{
    private int curr = 0;
    [SerializeField] private int capacity = 1;
    //might not be comparetag
    [SerializeField] private bool playerTriggered = false;
    
    //if only one is there then do this
    protected override void OnTriggerEnter(Collider other)
    {
        if ((playerTriggered && other.CompareTag("Player")) || (!playerTriggered))
        {
            curr += 1;
            if (active & curr == capacity)
            {
                Debug.Log("active");
                Solve();
            }   
        }
    }

    //if no one is there then do this
    protected override void OnTriggerExit(Collider other)
    {
        if ((playerTriggered && other.CompareTag("Player")) || (!playerTriggered))
        {
            curr -= 1;
            if (curr == capacity - 1)
            {
                SetActive(true);
                ExitSolveArea();
                Debug.Log("deactive");
            }   
        }
    }

    /**
     * Try solving function.
     */
    public override void TrySolve(Music key)
    {
    }
}
