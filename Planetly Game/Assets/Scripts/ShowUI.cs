using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;
    [SerializeField] private float juiceNumber = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

     void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

     IEnumerator WaitForSec()
     {
         yield return new WaitForSeconds(juiceNumber);
         Destroy(uiObject);
         Destroy(gameObject);
     }
}
