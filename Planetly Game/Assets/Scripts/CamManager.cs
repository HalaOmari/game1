using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cv1;
    

    // Update is called once per frame

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            cv1.Priority = 11;
        }
    }
    protected void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("exit");
            cv1.Priority = 9;
        }
    }
}