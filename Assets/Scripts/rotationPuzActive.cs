using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPuzActive : MonoBehaviour
{

    public GameObject[] pipes;
    public Material originalMaterial;
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
            
            GetComponent<Renderer>().material.color = Color.green;
           
            pipes = GameObject.FindGameObjectsWithTag("pipe");
            for (int i = 0; i < pipes.Length; i++)
            {
                pipes[i].GetComponent<MeshRenderer>().material.color = Color.green;
            }

        } else
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

    }
    void OnTriggerExit(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "rotation_puzzle_tag")
        {
            GetComponent<Renderer>().material = originalMaterial;
        }

    }
    //IEnumerator WaitForSound()
    //{
    //    yield return new WaitForSeconds(duration - 1);
    //    Debug.Log("FinishAudio");


    //    loadLevel.LoadingLevel(1);

    //}
}
