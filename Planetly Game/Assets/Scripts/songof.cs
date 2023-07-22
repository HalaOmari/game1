using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songof : MonoBehaviour
{
    //more of an example/template
    //also bad idea
    [SerializeField] private TypeErr openerr;
    [SerializeField] private GameObject collectable;
    // Start is called before the first frame update
    void Start()
    {
        //maybe add on enter solve area
        openerr.onSolve += riddlecomplete;
        openerr.onSolve += destorycollectablle;
    }
    
    
    public void riddlecomplete()
    {
        Debug.Log(("a winer is you"));
    }

    public void destorycollectablle()
    {
        Destroy(collectable);
    }
    
}
