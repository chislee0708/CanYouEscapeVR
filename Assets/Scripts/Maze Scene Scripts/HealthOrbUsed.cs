using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrbUsed : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        gameObject.SetActive(false);
    }
}
