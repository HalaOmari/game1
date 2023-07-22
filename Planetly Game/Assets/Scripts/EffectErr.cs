using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectErr : TypeErr
{
    // this error differs from the other err by having a temporary
    //effet that resets by leaving the appointed area
    [SerializeField] private List<Music> sequence;

    public int curSeq;
    private int SequenceLength;
    //used to do things per index
    public event Action<int> onType;
    public event Action<int> onFalse;
    
    void Start()
    {
        curSeq = 0;
        SequenceLength = sequence.Count;
    }
    
    //add to only refer to player
    protected override void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (active && other.CompareTag("Player"))
        {
            Debug.Log("active");
            CharacterManager.current.onPressMusicKey += TrySolve;
        }
    }

    //add to only refer to player
    protected override void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterManager.current.onPressMusicKey -= TrySolve;
            ExitSolveArea();
            Debug.Log("deactive");   
        }
    }


    private void Type(int key)
    {
        if (onType != null)
        {
            onType(key);
        }
    }

    private void False(int key)
    {
        if (onFalse != null)
        {
            onFalse(key);
        }
    }
    
    
    /**
     * Try solving function.
     */
    public override void TrySolve(Music key)
    {
        if (curSeq == SequenceLength - 1 && key.Equals(sequence[curSeq]))
        {
            Type(curSeq);
            Solve();
        }
        else if (key.Equals(sequence[curSeq]))
        {
            Type(curSeq);
            curSeq++;
        }
        else
        {
            False(curSeq);
            curSeq = 0;
        }

    }

}
