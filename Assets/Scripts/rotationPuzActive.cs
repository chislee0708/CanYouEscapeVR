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
            
           
            pipes = GameObject.FindGameObjectsWithTag("pipe"); //pipes are all objects with tag "pipe"
            for (int i = 0; i < pipes.Length; i++)
            {
                activator = true; // mark true because piece of puzzle solved
            }

        } 
    }
   
    void OnTriggerExit(Collider colidedObj)
    {
        if (colidedObj.gameObject.tag == "rotation_puzzle_tag")
        {
            
            activator = false; // mark false because piece of puzzle solved incorrectly
        }

    }

}
