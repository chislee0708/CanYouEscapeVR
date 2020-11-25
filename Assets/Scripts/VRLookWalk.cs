using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float bottom = 50.0f;
    public float speed = 5.0f;
    public bool moveForward;
    public AudioSource audioSource;

    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < bottom)
        {
            moveForward = true;
            if(audioSource.isPlaying == false)
            {
                audioSource.volume = Random.Range(0.8f, 1);
                audioSource.pitch = Random.Range(0.8f, 1.1f);
                audioSource.Play();
            }
        }
        else
        {
            moveForward = false;
            audioSource.Stop();
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }
}