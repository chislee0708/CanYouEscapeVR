using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair2_Activation : MonoBehaviour
{
    Animator DoorAnim;

    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pair2_Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair2_Pipe2").GetComponent<rotationPuzActive>().activator 
            && GameObject.Find("Pair2_Pipe3").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair2_Pipe4").GetComponent<rotationPuzActive>().activator)
        {
            DoorAnim.SetBool("CloseDoor", false);
        }
        //at least 1 puzzle pieces solved incorrectly
        else
        {
            DoorAnim.SetBool("CloseDoor", true);
        }
    }
}
