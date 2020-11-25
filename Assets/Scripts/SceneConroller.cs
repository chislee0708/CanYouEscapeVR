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
    }

    private void OnTriggerEnter(Collider other)
    {
        //Green Portal
        if (DoorColor == "Green")
        {
            SceneManager.LoadScene("New-Scene3-Alyona");
        }

        //Blue Portal
        //if (DoorColor == "Blue")
        //{
        //    SceneManager.LoadScene("");
        //}

        //Red Portal
        if (DoorColor == "Red")
        {
            SceneManager.LoadScene("Scene5-Troy");
        }

    }
}
