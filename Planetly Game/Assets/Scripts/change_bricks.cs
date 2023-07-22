using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class change_bricks : MonoBehaviour
{

    [SerializeField] private EffectErr err;
    [SerializeField] private List<GameObject> flowers;
    [SerializeField] private List<Sprite> flowersSprites;
    //[SerializeField] private Animator Door;
    [SerializeField] private float juiceNumber = 0.1f;
    private int flag=0;
    public static bool isBlocked=false;
    
    // Start is called before the first frame update
    void Start()
    {
        err.onType += changeColorCorrect;
        err.onFalse += changeColorWrong;
        err.onSolve += opendoor;
        isBlocked = false;
    }
    


    void changeColorCorrect(int index)
    {
        Debug.Log("In Correct ,index: "+index+"curSeq: "+err.curSeq);
        int max = Math.Min(index, flowers.Count - 1);
        int helperindex = 1;
        
        // check the correct Audio
        if (flag==0)
        {
            // sound for flower1
            FindObjectOfType<AudioManager>().Play("flower1");
            //Animation
            flowers[0].GetComponent<Animator>().SetBool("correct1",true);
        }

        else if (flag == 1)
        {
            // sound for flower2
            FindObjectOfType<AudioManager>().Play("flower2");
            //Animation
            flowers[1].GetComponent<Animator>().SetBool("correct2",true);

        }

        else if (flag == 2)
        {
            // sound for flower3
            FindObjectOfType<AudioManager>().Play("flower3");
            //Animation
            flowers[2].GetComponent<Animator>().SetBool("correct3",true);

            
        }
        else if (flag == 3)
        {
            //Animation
            flowers[3].GetComponent<Animator>().SetBool("correct4",true);
            // sound for flower4
            FindObjectOfType<AudioManager>().Play("flower4");
            flag = 4;
            turnoff();
            isBlocked = true;
            FindObjectOfType<AudioManager>().Play("endRiddle2");
        }
        flag++;
    }
    
    
    void changeColorWrong(int index)
    {
        Debug.Log("In Wrong ,index: "+index+"curSeq: "+err.curSeq);
        StartCoroutine(colorWrong(index));
    }
    
    IEnumerator colorWrong(int index)
    {
        int max = Math.Min(index, flowers.Count - 1);
        int helperindex = 2;
        for (int i = 0; i  <= max; i++)
        {
            flowers[i].GetComponent<SpriteRenderer>().sprite = flowersSprites[helperindex];
            helperindex += 3;
        }
        //might be unsafe
        isBlocked = true;
        yield return new WaitForSeconds(juiceNumber);
        isBlocked = false;
        resetcolors();
    }

    
    void resetcolors()
    {
        int helperindex = 0;
        foreach (var flower in flowers)
        {
            flower.GetComponent<SpriteRenderer>().sprite = flowersSprites[helperindex];
            helperindex += 3;
        }
        turnoff();
        FindObjectOfType<AudioManager>().Play("wrong9");
        flag = 0;
    }

    void turnoff()
    {
        if (flag==1)
        {
            //sound
            FindObjectOfType<AudioManager>().Pause("flower1");
            //animation
            flowers[0].GetComponent<Animator>().SetBool("correct1",false);
            
        }else if (flag == 2)
        {
            //sound
            FindObjectOfType<AudioManager>().Pause("flower1");
            FindObjectOfType<AudioManager>().Pause("flower2");
            // animation
            flowers[0].GetComponent<Animator>().SetBool("correct1",false);
            flowers[1].GetComponent<Animator>().SetBool("correct2",false);

        }else if (flag == 3)
        {
            FindObjectOfType<AudioManager>().Pause("flower1");
            FindObjectOfType<AudioManager>().Pause("flower2");
            FindObjectOfType<AudioManager>().Pause("flower3");
            // animation
            flowers[0].GetComponent<Animator>().SetBool("correct1",false);
            flowers[1].GetComponent<Animator>().SetBool("correct2",false);
            flowers[2].GetComponent<Animator>().SetBool("correct3",false);

        }else if (flag == 4)
        {
            FindObjectOfType<AudioManager>().Pause("flower1");
            FindObjectOfType<AudioManager>().Pause("flower2");
            FindObjectOfType<AudioManager>().Pause("flower3");
            FindObjectOfType<AudioManager>().Pause("flower4");
            //flowers[0].GetComponent<Animator>().SetBool("correct1",false);
            //flowers[1].GetComponent<Animator>().SetBool("correct2",false);
            //flowers[2].GetComponent<Animator>().SetBool("correct3",false);
            //flowers[3].GetComponent<Animator>().SetBool("correct4",false);
        }
    }
    
    void opendoor()
    {
        //Door.SetBool("open", true);
    }
}