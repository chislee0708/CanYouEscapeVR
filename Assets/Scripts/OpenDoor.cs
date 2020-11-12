using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation DoorAnimation;
    public GameObject key;
    //public LoadLevel loadLevel;
    //public AudioClip audio;
    public AudioSource soundDoor;

    //public GameObject LoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnimation.gameObject.GetComponent<Animator>().enabled = false;
        Debug.Log("door-start");
    }

    void OnTriggerEnter(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "key_tag") // if key is in the door
        {
            
            DoorAnimation.gameObject.GetComponent<Animator>().enabled = true;
            DoorAnimation.Play();
            Debug.Log("door");
            key.SetActive(false); //key is not visible

            soundDoor = GetComponent<AudioSource>();
            //soundDoor.clip = audio;

            
            soundDoor.Play();

            //StartCoroutine(WaitForSound());

            //GetComponent<Renderer>().material.color = Color.green; //change color to green



        }
    }

}