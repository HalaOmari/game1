using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dest_on_com : MonoBehaviour
{
    [SerializeField]private TypeErr on_en;
    private void Start()
    {
        on_en.onSolve += dest;
    }

    public void dest()
    {
        Debug.Log("bom");
        Destroy(gameObject);
    }
}
