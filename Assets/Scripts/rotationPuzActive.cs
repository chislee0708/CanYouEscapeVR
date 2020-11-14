using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPuzActive : MonoBehaviour
{

    public GameObject[] pipes;
    public Material originalMaterialB;
    public bool activator = false; //true if piece of puzzle solved
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "rotation_puzzle_tag") // if puzzle rotated correctly and got to its place
        {
            //DoorAnimation.Play();
            //soundDoor = GetComponent<AudioSource>();
            //soundDoor.clip = audio;

            //duration = audio.length;
            //soundDoor.Play();

            //StartCoroutine(WaitForSound());
            
            //GetComponent<Renderer>().material.color = Color.green; //change color to green
           
            pipes = GameObject.FindGameObjectsWithTag("pipe"); //pipes are all objects with tag "pipe"
            for (int i = 0; i < pipes.Length; i++)
            {
                //pipes[i].GetComponent<MeshRenderer>().material.color = Color.green;  //change color to green
                activator = true; // mark true because piece of puzzle solved
            }

        } 
    }
   
    void OnTriggerExit(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "rotation_puzzle_tag")
        {
            //GetComponent<Renderer>().material = originalMaterialB; // change to original color/material
            activator = false; // mark false because piece of puzzle solved incorrectly
        }

    }
    //IEnumerator WaitForSound()
    //{
    //    yield return new WaitForSeconds(duration - 1);
    //    Debug.Log("FinishAudio");


    //    loadLevel.LoadingLevel(1);

    //}
}
