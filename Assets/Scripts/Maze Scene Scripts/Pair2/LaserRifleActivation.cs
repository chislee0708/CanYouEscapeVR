using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRifleActivation : MonoBehaviour
{  
    //cansShoot controls the AutoCannon's activation
    public bool canShoot;
    public GameObject target;

    //AutoCannons are activated when the player triggers their collider
    void OnTriggerEnter(Collider colidedObj){
        target = colidedObj.gameObject;
        canShoot = true;
    }

    void OnTriggerExit(Collider colidedObj){
        canShoot = false;
    }
}
