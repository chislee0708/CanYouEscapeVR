using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{   

    public bool activator = false; //true if Player collided with Cannon
    // Start is called before the first frame update
    void OnTriggerEnter(Collider colidedObj){
        Debug.Log("OnCollisionEnter");
        Debug.Log(colidedObj.gameObject.name);
        activator = true;
    }

    void OnTriggerExit(Collider collidedObj){
        activator = false;
    }
}
