using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    // public static Player current;
    // [SerializeField] private Rigidbody player;
    // [SerializeField] private List<AudioClip> sounds;
    //
    //
    //
    // private void Awake()
    // {
    //     current = this;
    //     onPressMusicKey += playsound;
    // }
    //
    // public event Action<KeyCode> onPressMusicKey;
    //
    // public void PressMusicKey(KeyCode key)
    // {
    //     if (onPressMusicKey != null)
    //     {
    //         onPressMusicKey(key);
    //     }
    // }
    //
    // //temp code for the showcase
    // public void playsound(KeyCode key)
    // {
    //     if (Input.GetKeyDown(KeyCode.Q))
    //     {
    //         AudioSource audio = GetComponent<AudioSource>();
    //         audio.clip = sounds[0];
    //         audio.Play();
    //     }
    //     if (Input.GetKeyDown(KeyCode.W))
    //     {
    //         AudioSource audio = GetComponent<AudioSource>();
    //         audio.clip = sounds[1];
    //         audio.Play();
    //     }
    //     if (Input.GetKeyDown(KeyCode.E))
    //     {
    //         AudioSource audio = GetComponent<AudioSource>();
    //         audio.clip = sounds[2];
    //         audio.Play();
    //     }
    // }
    //
    //
    //
    // //will handle using a key
    //
    // //temporary due to not having a player
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Q))
    //     {
    //         PressMusicKey(KeyCode.Q);
    //     }
    //     if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         player.MoveRotation(player.rotation * Quaternion.Euler( new Vector3(0, 30, 0) * Time.fixedDeltaTime));
    //     }
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         player.MoveRotation(player.rotation * Quaternion.Euler( new Vector3(0, -30, 0) * Time.fixedDeltaTime));
    //     }
    //     if (Input.GetKey(KeyCode.UpArrow))
    //     {
    //         player.AddForce(player.transform.forward * -20);
    //     }
    //     if (Input.GetKey(KeyCode.DownArrow))
    //     {
    //         player.AddForce(player.transform.forward * 20);
    //     }
    //     if (Input.GetKey(KeyCode.Space))
    //     {
    //         player.AddForce(new Vector3(0,10,0));
    //     }
    //     if (Input.GetKeyDown(KeyCode.W))
    //     {
    //         PressMusicKey(KeyCode.W);
    //     }
    //     if (Input.GetKeyDown(KeyCode.E))
    //     {
    //         PressMusicKey(KeyCode.E);
    //     }
    // }

}
