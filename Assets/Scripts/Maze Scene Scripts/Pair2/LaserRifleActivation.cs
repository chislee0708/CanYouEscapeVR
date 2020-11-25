using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRifleActivation : MonoBehaviour
{  
    HandGunToggle scriptLink;
    //cansShoot controls the AutoCannon's activation
    public bool canShoot;
    public GameObject target;

    void Start()
    {
        scriptLink = GameObject.FindGameObjectWithTag("Hand_Gun").GetComponent<HandGunToggle>();
    }
    //AutoCannons are activated when the player triggers their collider
    void OnTriggerEnter(Collider colidedObj){
        target = colidedObj.gameObject;
        scriptLink.ChangeStatus();
        canShoot = true;
    }

    void OnTriggerExit(Collider colidedObj){
        scriptLink.ChangeStatus();
        canShoot = false;
    }
}
