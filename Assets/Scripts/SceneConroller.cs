using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConroller : MonoBehaviour
{
    public string DoorColor;
    private int nextScenceLoad;

    private void Start()
    {
        //nextScenceLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (DoorColor == "Green")
        {
            SceneManager.LoadScene("New-Scene3-Alyona");
        }

        //Blue
        //if (DoorColor == "Blue")
        //{
        //    SceneManager.LoadScene("");
        //}

        //Red
        //if (DoorColor == "Red")
        //{
        //    SceneManager.LoadScene("");
        //}

        //SceneManager.LoadScene(nextScenceLoad);
    }
}
