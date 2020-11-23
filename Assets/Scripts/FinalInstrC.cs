using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalInstrC : MonoBehaviour
{
    public Material originalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {
        SceneManager.LoadScene(3);
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
