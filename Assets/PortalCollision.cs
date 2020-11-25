using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collidedObj)
    {
        if(collidedObj.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene1 - Mainroom");
        }
    }
}
