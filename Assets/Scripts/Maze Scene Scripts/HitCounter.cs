using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter : MonoBehaviour
{
    private int hitCount;

    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(hitCount >= 4){
            GameObject.Find("AutoCannon").SetActive(false);
        }
    }

    public void incrementCount()
    {
        hitCount++;
    }
}
