using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5OpenDoor : MonoBehaviour
{
    public Animation DoorAnimation;
    public AudioSource soundDoor;
    private float duration;
    public AudioClip audio;
    public bool PuzzleComplete = false;

    //public GameObject LoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnimation.gameObject.GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        /*
        if()
        {
            PuzzleComplete = true;
        }
        if(PuzzleComplete == true)
        {
            OpenDoor();
        }
        */
    }

    void OpenDoor()
    {
        soundDoor.Stop();
        if (soundDoor.isPlaying == false)
                {
                    soundDoor.Play();
                }
                DoorAnimation.gameObject.GetComponent<Animator>().enabled = true;
                DoorAnimation.Play();
    }













}