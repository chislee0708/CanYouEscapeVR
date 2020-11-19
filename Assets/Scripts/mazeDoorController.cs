using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeDoorController : MonoBehaviour
{   
    //Fetch the Animator
    Animator mazeDoorAnimator;
    bool closeDoor;

    public GameObject Door1;
    
    // Start is called before the first frame update
    void Start()
    {
        mazeDoorAnimator = new Door.GetComponent<Animator>();
        closeDoor = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe2").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe3").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pipe4").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe5").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe6").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pipe7").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe8").GetComponent<rotationPuzActive>().activator)
        {
            GetComponent<Renderer>().material.color = Color.green; //change color to green
            closeDoor = false;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red; //change color to red
            closeDoor = true;
        }

        if(closeDoor == false)
            mazeDoorAnimator.SetBoolean("CloseDoor", false);

        if(closeDoor == true)
            mazeDoorAnimator.SetBoolean("CloseDoor", true);
    }
}