using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door5_Activation : MonoBehaviour
{
    Animator DoorAnim;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collidedObj)
    {
        if(collidedObj.gameObject.tag == "Player")
        {
            DoorAnim.SetBool("CloseDoor", false);
        }
    }
}
