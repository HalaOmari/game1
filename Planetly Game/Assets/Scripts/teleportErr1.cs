using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportErr1 : TypeErr
{
    //this riddle is not solvable, it only does things when you enter it
    //might not be comparetag
    [SerializeField] private bool playerTriggered = false;
    [SerializeField] private GameObject DestinationBody;

    private Vector3 Destination;

    void Start()
    {
        Destination = DestinationBody.transform.position;
    }

    //if only one is there then do this
    protected override void OnTriggerEnter(Collider other)
    {
        if ((playerTriggered && other.CompareTag("Player")) || (!playerTriggered))
        {
            if (active)
            {
                other.transform.GetComponent<CharacterManager>().Teleport(Destination);
            }   
        }
    }

    //does nothing
    protected override void OnTriggerExit(Collider other)
    {
    }

    /**
     * Try solving function.
     */
    public override void TrySolve(Music key)
    {
    }
}
