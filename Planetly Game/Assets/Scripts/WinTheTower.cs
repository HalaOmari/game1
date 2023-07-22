using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTheTower : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.GetComponent<AudioSource>().Play();
        }
    }
}
