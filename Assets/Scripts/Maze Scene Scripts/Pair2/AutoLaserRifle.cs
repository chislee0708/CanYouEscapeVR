using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLaserRifle : MonoBehaviour
{
    public GameObject m_shotPrefab;

    RaycastHit hit;
    float range = 1000.0f;
    private float nextFireTimeStamp;
    private Vector3 target_position;

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
        Ray ray = new Ray(transform.position, target_position);
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log("Ray hit: " + hit.collider + " At: " + hit.collider.transform.position);
            Debug.Log("Target at: " + target_position);
            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<BeamBehavior>().setTarget(target_position);
            GameObject.Destroy(laser, 0.25f);
        } 
    }
}
