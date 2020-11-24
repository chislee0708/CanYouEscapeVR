using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckColour : MonoBehaviour
{
    public GameObject Cube;
    public string CurrentCube;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EventTrigger>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        EnableColour();
    }

    void EnableColour()
    {
        if (CurrentCube == "Second") { 
            if (Cube.gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                GetComponent<EventTrigger>().enabled = true;
            }
        }
        if (CurrentCube == "Third")
        {
            if (Cube.gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                GetComponent<EventTrigger>().enabled = true;
            }
        }
        if (CurrentCube == "Last")
        {
            if (Cube.gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
                GetComponent<EventTrigger>().enabled = true;
            }
        }
    }
}
