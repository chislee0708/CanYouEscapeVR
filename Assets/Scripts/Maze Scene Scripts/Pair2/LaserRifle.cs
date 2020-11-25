using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRifle : MonoBehaviour
{
    public GameObject m_shotPrefab;

    HitCounter scriptLink1;
    HitCounter3 scriptLink2;

    RaycastHit hit;
    float range = 200.0f;
    private float nextFireTimeStamp;

    void Start()
    {
        //Creates a reference to the Ammo Object's HitCount script
        scriptLink1 = GameObject.FindGameObjectWithTag("Ammo").GetComponent<HitCounter>();
        scriptLink2 = GameObject.FindGameObjectWithTag("Ammo2").GetComponent<HitCounter3>();
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
            if(hit.collider.gameObject.tag == "Ammo")
            {
                //If ray hits Ammo Object, Ammo's HitCount is incremented.
                scriptLink1.incrementCount();
            }
            else if(hit.collider.gameObject.tag == "Ammo2")
            {
                scriptLink2.incrementCount();
            }

            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<BeamBehavior>().setTarget(hit.point);
            GameObject.Destroy(laser, 0.25f);
        }
    }
}