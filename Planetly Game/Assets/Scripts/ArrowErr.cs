using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class ArrowErr : TypeErr
{
    //this error is the standard error, once you solve it you cant unsolve, and once
    // leving the area it wont do anything
    [SerializeField] private List<KeyCode> sequence;
    private int curSeq;
    private int SequenceLength;
    
    
    void Start()
    {
        curSeq = 0;
        SequenceLength = sequence.Count;
    }

    //add to only refer to player
    protected override void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Debug.Log("active");
            CharacterManager.current.onPressMusicKey += TrySolve;
        }
    }

    //add to only refer to player
    protected override void OnTriggerExit(Collider other)
    {
        CharacterManager.current.onPressMusicKey -= TrySolve;
        ExitSolveArea();
        Debug.Log("deactive");
    }

    /**
     * Try solving function.
     */
    public override void TrySolve(Music key)
    {
        Debug.Log(curSeq);
        if (curSeq == SequenceLength - 1 && key.Equals(sequence[curSeq]))
        {
            Solve();
        }
        else if (key.Equals(sequence[curSeq]))
        {
            curSeq += 1;
        }
        else
        {
            curSeq = 0;
        }
    }

}
