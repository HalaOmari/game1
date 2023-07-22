using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkur_manager : MonoBehaviour
{
    [SerializeField] private onEnterErr err;
    // Start is called before the first frame update
    void Start()
    {
        err.onExitSolveArea += parkuroff;
        err.onSolve += parkuron;
    }

    
    
    public void parkuron()
    {
        CharacterManager.current.parkur = true;
        Debug.Log(CharacterManager.current.parkur);
    }

    public void parkuroff()
    {
        CharacterManager.current.parkur = false;
        Debug.Log(CharacterManager.current.parkur);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
