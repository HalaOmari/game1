using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class RiddleOneInteractableManager : MonoBehaviour
{
    [SerializeField] private GameObject castle;
    [SerializeField] private CinemachineVirtualCamera cv1;
    

    // Update is called once per frame

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            castle.transform.GetComponent<CastleManager>().enabled = true;
            Debug.Log("enter");
            cv1.Priority = 11;
            transform.parent.GetComponent<CastleBillboard>().enabled = false;
            
        }
    }
    protected void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            castle.transform.GetComponent<CastleManager>().enabled = false;
            Debug.Log("exit");
            cv1.Priority = 9;
            transform.parent.GetComponent<CastleBillboard>().enabled = true;
        }
    }
}
