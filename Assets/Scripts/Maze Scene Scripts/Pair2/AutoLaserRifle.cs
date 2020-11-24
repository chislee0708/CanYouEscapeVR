using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLaserRifle : MonoBehaviour
{
    public GameObject m_shotPrefab;

    RaycastHit hit;
    float range = 50f;
    private float nextFireTimeStamp;

    void Update()
    {
        if(GameObject.Find("Endpoint_Sensor").GetComponent<LaserRifleActivation>().canShoot & (Time.time > nextFireTimeStamp ))
        {
            GameObject target = GameObject.Find("Endpoint_Sensor").GetComponent<LaserRifleActivation>().target;
            shootRay(target);
            nextFireTimeStamp = Time.time + 2;
        } 
    }

    void shootRay(GameObject target)
    {   
        Vector3 target_position = target.transform.position;
        Ray ray = new Ray(transform.position, target_position-transform.position);
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log("Ray hit: " + hit.collider + " At: " + hit.collider.transform.position);
            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<BeamBehavior>().setTarget(target_position);
            GameObject.Destroy(laser, 0.5f);
        } 
    }
}
