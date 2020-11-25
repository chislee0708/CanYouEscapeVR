using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3_Activation : MonoBehaviour
{
    Animator DoorAnim;

    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }
    
    public void activateDoor()
    {
        DoorAnim.SetBool("CloseDoor", false);
    }
}
