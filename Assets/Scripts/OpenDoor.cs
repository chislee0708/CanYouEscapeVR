﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public Animation DoorAnimation;
    public GameObject key;
    public AudioSource soundDoor;
    private float duration;
    public AudioClip audio;

    //public GameObject LoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnimation.gameObject.GetComponent<Animator>().enabled = false;
    }

    void OnTriggerEnter(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "key_tag") // if key is in the door
        {
            
            DoorAnimation.gameObject.GetComponent<Animator>().enabled = true;
            DoorAnimation.Play();
            soundDoor = GetComponent<AudioSource>();
            soundDoor.clip = audio;
            key.SetActive(false); //key is not visible
            duration = audio.length;
            soundDoor.Play();
            StartCoroutine(WaitForSound());
        }
    }
    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(duration + 2);
        Debug.Log("FinishAudio");
        key.SetActive(false); //key is not visible

        
        SceneManager.LoadScene(2);

    }

}