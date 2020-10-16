using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPuzActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "rotation_puzzle_tag")
        {
            //DoorAnimation.Play();
            //soundDoor = GetComponent<AudioSource>();
            //soundDoor.clip = audio;

            //duration = audio.length;
            //soundDoor.Play();

            //StartCoroutine(WaitForSound());
            print("col");
            GetComponent<Renderer>().material.color = Color.red;
        }

    }
    //IEnumerator WaitForSound()
    //{
    //    yield return new WaitForSeconds(duration - 1);
    //    Debug.Log("FinishAudio");

   
    //    loadLevel.LoadingLevel(1);

   //}
}
