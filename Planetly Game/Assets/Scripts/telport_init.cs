using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telport_init : MonoBehaviour
{
    [SerializeField] private TypeErr openerr;
    [SerializeField] private GameObject Destination;
    // Start is called before the first frame update
    void Start()
    {
        
        openerr.onSolve += teleport;
    }


    // Update is called once per frame
    void teleport()
    {
        
    }
}
