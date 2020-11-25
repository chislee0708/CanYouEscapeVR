using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter : MonoBehaviour
{
    private int hitCount;
    public string cannonName;

    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        //**************//
        Debug.Log("CANNON NAME: " + cannonName);
        
        if(hitCount >= 4){
            GameObject.Find(cannonName).SetActive(false);
        }
    }

    public void incrementCount()
    {
        hitCount++;
    }
}
