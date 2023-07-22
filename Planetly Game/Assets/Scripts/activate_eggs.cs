using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_eggs : MonoBehaviour
{
    [SerializeField] private List<TypeErr> errs;
    [SerializeField] private GameObject[] eggs;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        //didnt do it with order due to not wanting unlinear riddles
        foreach (var err in errs)
        {
            err.onSolve += activate_egg;
        }
    }

    public void activate_egg()
    {
        if (eggs.Length > index)
        {
            eggs[index].SetActive(true);
            index++;
        }
    }
}
