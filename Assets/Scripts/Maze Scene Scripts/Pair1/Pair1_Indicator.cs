using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair1_Indicator : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pair1_Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair1_Pipe2").GetComponent<rotationPuzActive>().activator 
            && GameObject.Find("Pair1_Pipe3").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair1_Pipe4").GetComponent<rotationPuzActive>().activator)
        {
            GetComponent<Renderer>().material.color = Color.green; //change color to green  
        }
        //at least 1 puzzle pieces solved incorrectly
        else
        {
            GetComponent<Renderer>().material.color = Color.red; //change color to red
        }
    }
}