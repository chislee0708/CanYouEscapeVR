using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MINIgame : MonoBehaviour
{
    public Material originalMaterial;
    
    public void HighlightButton()
    {
        GetComponent<Renderer>().material.color = Color.black;

    }
    public void originalButton()
    {
        GetComponent<Renderer>().material = originalMaterial;

    }
    public void StartMiniGame()
    {
        SceneManager.LoadScene(2);
    }
}
