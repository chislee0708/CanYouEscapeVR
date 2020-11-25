using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair1_Activation : MonoBehaviour
{
    Animator DoorAnim;
    bool TurretActive;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = GetComponent<Animator>();
        TurretActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pair1_Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair1_Pipe2").GetComponent<rotationPuzActive>().activator 
            && GameObject.Find("Pair1_Pipe3").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pair1_Pipe4").GetComponent<rotationPuzActive>().activator
            && !TurretActive)
        {
            DoorAnim.SetBool("CloseDoor", false);
        }
        //at least 1 puzzle pieces solved incorrectly
        else
        {
            DoorAnim.SetBool("CloseDoor", true);
        }
    }

    public void shutTurretDown()
    {
        TurretActive = false;
    }

}
