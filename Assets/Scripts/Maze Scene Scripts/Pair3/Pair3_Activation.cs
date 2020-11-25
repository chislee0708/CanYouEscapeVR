﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair3_Activation : MonoBehaviour
{
    Animator DoorAnim;
    bool TurretActive;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pair3_Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair3_Pipe2").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair3_Pipe3").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pair3_Pipe4").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair3_Pipe5").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair3_Pipe6").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pair3_Pipe7").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair3_Pipe8").GetComponent<rotationPuzActive>().activator)
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
