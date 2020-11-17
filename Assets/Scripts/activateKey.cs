using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateKey : MonoBehaviour
{
    public GameObject key;
    public GameObject getKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if all puzzle pieces solved correctly
        if(GameObject.Find("Pipe1").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe2").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe3").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pipe4").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe5").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe6").GetComponent<rotationPuzActive>().activator
            && GameObject.Find("Pipe7").GetComponent<rotationPuzActive>().activator && GameObject.Find("Pipe8").GetComponent<rotationPuzActive>().activator)
        {
            GetComponent<Renderer>().material.color = Color.green; //change color to green
            key.SetActive(true); //key is visible
            getKey.SetActive(true); //key is visible
        }
        //at least 1 puzzle pieces solved incorrectly
        else
        {
            GetComponent<Renderer>().material.color = Color.red; //change color to red
            key.SetActive(false); //key is not visible
            getKey.SetActive(false); //key is not visible
        }
    }
}
