using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playnote : MonoBehaviour
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private AudioSource source;
    // Start is called before the first frame update
    
    void Start()
    {
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.clip = sound;
            source.Play();
        }
    }
    
}
