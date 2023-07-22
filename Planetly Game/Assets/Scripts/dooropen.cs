using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    [SerializeField] private TypeErr openerr;
    // [SerializeField] private Animator anmManager;
    // Start is called before the first frame update
    void Start()
    {
        openerr.onSolve += opendoor;
        openerr.onExitSolveArea += closedoor;
    }

    public void opendoor()
    {
        gameObject.SetActive(false);
        // anmManager.SetBool("open", true);
    }
    
    public void closedoor()
    {
        gameObject.SetActive(true);
        // anmManager.SetBool("open", true);
    }
}
