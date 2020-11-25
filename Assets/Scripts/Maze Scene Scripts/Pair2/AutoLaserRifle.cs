using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLaserRifle : MonoBehaviour
{
    //Link to PlayerHitCountScript to increment HitCount
    //BoxColliders are too slow to keep track of all RayCaster Collisions.
    //To fix this I had the RayCaster track colliosions instead.
    PlayerHitCount scriptLink;

    public GameObject m_shotPrefab;

    RaycastHit hit;
    float range = 150f;
    private float nextFireTimeStamp;

    void Start()
    {
        //Creates a reference to the Player Object's PlayerHitCount script
        scriptLink = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHitCount>();
    }

    void Update()
    {
        if(GameObject.Find("Endpoint_Sensor").GetComponent<LaserRifleActivation>().canShoot & (Time.time > nextFireTimeStamp ))
        {
            GameObject target = GameObject.Find("Endpoint_Sensor").GetComponent<LaserRifleActivation>().target;
            shootRay(target);
            //This is used to control the turret's cooldown time
            nextFireTimeStamp = Time.time + 1.25f;
        } 
    }

    void shootRay(GameObject target)
    {   
        Vector3 target_position = target.transform.position;
        Ray ray = new Ray(transform.position, target_position-transform.position);
        if (Physics.Raycast(ray, out hit, range))
        {
            // Debug.Log("Ray hit: " + hit.collider + " At: " + hit.collider.transform.position);

            if(hit.collider.gameObject.tag == "Player")
            {
                //If ray hits Player, Player's HitCount is incremented.
                scriptLink.incrementCount();

                GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
                laser.GetComponent<BeamBehavior>().setTarget(target_position);
                GameObject.Destroy(laser, 2f);
            }
        } 
    }
}
