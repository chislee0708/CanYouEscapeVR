﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AudioSource sound;

    public Material originalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Yellow()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void RotateObj()
    {
        transform.Rotate(0, 90, 0);
        sound.Play();
    }

    public void Red()
    {
        GetComponent<Renderer>().material = originalMaterial;
    }
}
