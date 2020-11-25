using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter3 : MonoBehaviour
{
    private int hitCount;
    public string cannonName;
    public string doorName;

    HandGunToggle toggleScriptLink;


    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;
        toggleScriptLink = GameObject.FindGameObjectWithTag("Hand_Gun").GetComponent<HandGunToggle>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //Turret2 is a bit harder to destroy
        if(hitCount >= 6){
            GameObject.Find(cannonName).SetActive(false);
            GameObject.Find(doorName).GetComponent<Door3_Activation>().activateDoor();
            toggleScriptLink.ChangeStatus();
        }
    }

    public void incrementCount()
    {
        hitCount++;
    }
}