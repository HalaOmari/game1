using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportGateManager : MonoBehaviour
{
    //this riddle is not solvable, it only does things when you enter it
    //might not be comparetag
    [SerializeField] private GameObject castle;

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.GetComponent<CharacterManager>().Teleport(
                castle.transform.GetComponent<CastleManager>().getTeleportDestination(
                    gameObject).transform.GetChild(0).position);
        }
    }

    //does nothing
    protected void OnTriggerExit(Collider other)
    {
    }

    /**
     * Try solving function.
     */
    public void TrySolve(KeyCode key)
    {
    }
}
