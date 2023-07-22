using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compass_actingup : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private List<GameObject> objectives;
    [SerializeField] private List<GameObject> eggs;
    [SerializeField] private List<GameObject> sps;
    [SerializeField] private teleportErr watererr;
    [SerializeField] private GameObject compass;
    [SerializeField] private List<TypeErr> errs;
    
    private Camera theCam;    
    private GameObject curr_objective = null;
    private float angle;
    private int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        foreach (var err in errs)
        {
            err.onSolve += next_objective;
        }
        theCam = Camera.main;
        set_objective();
    }

    // Update is called once per frame
    void Update()
    {
        if (curr_objective)
        {
            angle = Vector3.SignedAngle(player.transform.position, curr_objective.transform.position, theCam.transform.forward);
            compass.transform.rotation = Quaternion.Euler(0f, 0 , angle - 270);
        }
    }
    public void set_objective()
    {
        if (objectives.Count > index)
        {
            curr_objective = objectives[index];
            index++;
        }
    }
    
    public void next_objective()
    {
        if (objectives.Count > index)
        {
            eggs[index - 1].SetActive(true);
            watererr.change_dest(sps[index - 1]);
            curr_objective = objectives[index];
            index++;
        }
    }

    
}
