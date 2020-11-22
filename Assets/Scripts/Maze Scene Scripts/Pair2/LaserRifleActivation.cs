using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRifleActivation : MonoBehaviour
{
    public bool canShoot;
    public GameObject target;

    public float shootRate;
    private float m_shootRateTimeStamp;

    void OnTriggerEnter(Collider colidedObj){
        Debug.Log("OnCollisionEnter");

        if((Time.time > m_shootRateTimeStamp))
        {
            target = colidedObj.gameObject;
            m_shootRateTimeStamp = Time.time + shootRate;
            
            canShoot = true;
        }
    }

    void OnTriggerExit(Collider colidedObj){
        canShoot = false;
    }
}
