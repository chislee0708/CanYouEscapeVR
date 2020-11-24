using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlight : MonoBehaviour
{
    public GameObject movingObj;
    public Material originalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        movingObj.GetComponent<SpaceshipMove>().canMove = false; // prevent movement before start button pressed 
    }

    public void StartGame()
    {
        movingObj.GetComponent<SpaceshipMove>().canMove = true; 
        GameObject.Find("Intro").SetActive(false);
    }
    public void HighlightButton()
    {
        GetComponent<Renderer>().material.color = Color.yellow;

    }
    public void originalButton()
    {
        GetComponent<Renderer>().material = originalMaterial;

    }
}
