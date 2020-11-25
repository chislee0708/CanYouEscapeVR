using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class LightPattern : MonoBehaviour
{
    public bool IsComplete = false;
    public GameObject[] pieces = new GameObject[4]; // for pieces of light up puzzle, " squares "
    public GameObject[] ings = new GameObject[5]; // to control ingredient set active qualities 
    public float time = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject ing in ings)
        {
            ing.SetActive(false);
        }
        
        // makes all ingredients dissapear until light puzzle is completed
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void StartPuzzle()
    {   
            time -= Time.deltaTime;
            if (time < 0)
            {
                pieces[0].GetComponent<Renderer>().material.color = Color.red;
                time = 20.0f;
            }

        pieces[0].GetComponent<Renderer>().material.color = Color.red;

        pieces[1].GetComponent<Renderer>().material.color = Color.red;
        pieces[2].GetComponent<Renderer>().material.color = Color.red;

    }

    // light up pattern can repeat and check inbetween delay if all pieces are right color 
    // then next puzzle or finish and setactive(true) for ingredients

    void SetIngredientsActive()
    {
        if (IsComplete == true)
        {
            foreach(GameObject ing in ings)
            {
                ing.SetActive(true);
            }
        }
    }

}
