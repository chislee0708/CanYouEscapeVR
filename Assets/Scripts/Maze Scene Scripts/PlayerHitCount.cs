using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitCount : MonoBehaviour
{
    public int playerHitCount;
    // Start is called before the first frame update
    void Start()
    {
        playerHitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collidedObj)
    {
        playerHitCount++;
        
    }
}
