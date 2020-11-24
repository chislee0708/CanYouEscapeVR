using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRifle : MonoBehaviour
{
    public GameObject m_shotPrefab;

    HitCounter scriptLink;

    RaycastHit hit;
    float range = 150.0f;
    private float nextFireTimeStamp;

    void Start()
    {
        //Creates a reference to the Ammo Object's HitCount script
        scriptLink = GameObject.FindGameObjectWithTag("Ammo").GetComponent<HitCounter>();
    }

    void Update()
    {   
        if (Input.GetMouseButton(0))
        {
            if (Time.time > nextFireTimeStamp)
            {
                shootRay();
                nextFireTimeStamp = Time.time + 0.75f;
            }
        }
    }

    void shootRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, range))
        {
            //HERE
            Debug.Log(hit.collider.gameObject.tag);
            
            if(hit.collider.gameObject.tag == "Ammo")
            {
                //If ray hits Ammo Object, Ammo's HitCount is incremented.
                scriptLink.incrementCount();
            }

            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<BeamBehavior>().setTarget(hit.point);
            GameObject.Destroy(laser, 2f);
        }
    }
}