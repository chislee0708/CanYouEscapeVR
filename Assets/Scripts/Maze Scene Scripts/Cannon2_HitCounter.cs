using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon2_HitCounter : MonoBehaviour
{
    private int hitCount;
    public string cannonName;
    public string doorName;

    HandGunToggle scriptLink;

    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;
        scriptLink = GameObject.FindGameObjectWithTag("Hand_Gun").GetComponent<HandGunToggle>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(hitCount >= 4){
            GameObject.Find(doorName).GetComponent<Pair1_Activation>().shutTurretDown();
            GameObject.Find(cannonName).SetActive(false);
            scriptLink.ChangeStatus();
        }
    }

    public void incrementCount()
    {
        hitCount++;
    }
}
