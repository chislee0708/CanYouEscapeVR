using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    public Material[] materials; // Input of material colors
    public Renderer rend; //Rendering Object
    public AudioSource audioSource;
    public string cube;

    // Start is called before the first frame update

    private int index = 1;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        index += 1;

        //Reset to the first material color when reaches the end
        if(index == materials.Length + 1)
        {
            index = 1;
        }
        rend.sharedMaterial = materials[index - 1];
    }

    

}
