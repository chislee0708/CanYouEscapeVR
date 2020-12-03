using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class LightPattern : MonoBehaviour
{
    public bool IsComplete = false; // for light puzzle comp 1
    public bool IsComplete2 = false; // for light puzzle comp 2
    public bool CompletedPuzzle = false; // for light puzzle
    public bool puzzleInitialized = false;
    public GameObject[] pieces = new GameObject[4]; // for pieces of light up puzzle, " squares "
    public GameObject[] ings = new GameObject[5]; // to control ingredient set active qualities 
    public GameObject medpack;
    public GameObject hand;
    public float time = 2.5f;
    public float time2 = 5.0f;
    public float time3 = 7.5f;
    private int j = 0;
    
   
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject ing in ings)
        {
            ing.SetActive(false);
        } 
        hand.SetActive(false);
        medpack.SetActive(false);
        // makes all ingredients dissapear until light puzzle is completed
    }

    
    // Update is called once per frame
    void Update()
    {
        //time3 -= Time.deltaTime;
        if(CompletedPuzzle == false)
        {
            time3 -= Time.deltaTime;
            if(time3 <= 0)
            {
                Puzzle();
            }
            if(puzzleInitialized == true)
            {
                time2 -= Time.deltaTime;
                if(time2 <= 0)
                {
                    //CheckPuzzle();
                   
                    Debug.Log("Completed puzzle");
                    SetIngredientsActive();
                    pieces[0].GetComponent<GazePieces>().ResetChangedColor();
                    pieces[1].GetComponent<GazePieces>().ResetChangedColor();
                    pieces[2].GetComponent<GazePieces>().ResetChangedColor();
                    pieces[3].GetComponent<GazePieces>().ResetChangedColor();
                    puzzleInitialized = false;
                    CompletedPuzzle = true;

            //time = 10.0f;
                }
            }
        }
        else
        {
            SetIngredientsActive();
            GameObject.Find("Board").GetComponent<LightPattern>().enabled = false;
        }
            /*
            if(time3 <= 0)
            {
                Puzzle();
            }
            while(time2 >= 0)
            {
                time2 -= Time.deltaTime;
            }
            if(time2 <= 0)
            {
                CheckPuzzle();
            }
            
            Puzzle();
            while(time2 >= 0)
            {
                time2 -= Time.deltaTime;
            }
            if(time2 <= 0)
            {
                CheckPuzzle();
            }
            SetIngredientsActive();

            CompletedPuzzle = true;
                
            SetIngredientsActive();
            */
            
        
        /*
        while(CompletedPuzzle == true && CompletedPuzzle2 == false)
        {

        
        }
        */
    }

    void Puzzle()
    {   
        /*
        for(int i = 0; i < 3; i++)
        {
            pieces[j].GetComponent<Renderer>().material.color = Color.red;
        }
        */
        pieces[0].GetComponent<Renderer>().material.color = Color.red;
        pieces[1].GetComponent<Renderer>().material.color = Color.red;
        pieces[2].GetComponent<Renderer>().material.color = Color.red;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            pieces[0].GetComponent<Renderer>().material.color = Color.blue;
            pieces[1].GetComponent<Renderer>().material.color = Color.blue;
            pieces[2].GetComponent<Renderer>().material.color = Color.blue;
            puzzleInitialized = true;
        }
        /*
        if(j <= 3)
        {
            pieces[j].GetComponent<Renderer>().material.color = Color.red;
            time -= Time.deltaTime;
            if (time <= 0)
            {
                    pieces[j].GetComponent<Renderer>().material.color = Color.blue;
                    j++;
            }
        }    
        /*
            // Delay Loop to let pieces light up non instantaneously
            for(int j = 0; j < 1000; j++)
            {
                if(j == 999)
                {
                    Debug.Log("delay between lighting up pieces complete");
                }
            }
        }
        
        time -= Time.deltaTime;
        if (time <= 0)
        {
            for(int i = 0; i < 3; i++)
            {
                pieces[i].GetComponent<Renderer>().material.color = Color.blue;
            }
        }
        time = 0;
        */
        
    }

    void CheckPuzzle()
    {
        // get func from pieces that have gaze piece script attached and get bools to see if sqaures were correctly viewed
        //if(pieces[0].GetComponent<GazePieces>().ChangedColor() == true && pieces[1].GetComponent<GazePieces>().ChangedColor() == true && pieces[2].GetComponent<GazePieces>().ChangedColor() == true) // pieces were changed to red via gazePieces
        //{
            for(int i = 0; i < 4; i++) // needs to set all to false including fourth piece for next puzzle
            {
                pieces[i].GetComponent<GazePieces>().ResetChangedColor();
            }
            IsComplete = true;
            CompletedPuzzle = true;
            Debug.Log("Completed puzzle");
            SetIngredientsActive();
            puzzleInitialized = false;
            //time = 10.0f;
            //time2 = 10.0f;
        //}
        
        //else
        //{
            //for(int i = 0; i < 4; i++) // needs to set all to false including fourth piece so puzzle can be reattempted
            //{
            //    pieces[i].GetComponent<GazePieces>().ResetChangedColor();
            //}
            /*
            time3 -= Time.deltaTime;
            if(time3 <= 0)
            {
                Puzzle();
            }
            time2 -= Time.deltaTime;
            if(time2 <= 0)
            {
                CheckPuzzle();
            }
            */
            //ResetAllTimes();
        //}
        
    }

    /*
    void Puzzle2()
    {
        pieces[1].GetComponent<Renderer>().material.color = Color.red; 
        pieces[2].GetComponent<Renderer>().material.color = Color.red; 
    }

     void CheckPuzzle2()
    {
        if(pieces[1].GetComponent<GazePieces>().ChangedColor() == true && pieces[2].GetComponent<GazePieces>().ChangedColor() == true) // 2nd and 4th piece light up 
        {
            for(int i = 0; i < 4; i++) // needs to set all to false including fourth piece for next puzzle
            {
                pieces[i].GetComponent<GazePieces>().ResetChangedColor();
            }
        }
        pieces[1].GetComponent<Renderer>().material.color = Color.red;

        pieces[0].GetComponent<Renderer>().material.color = Color.red;

        pieces[2].GetComponent<Renderer>().material.color = Color.red;

        SetIngredientsActive();
        IsComplete2 = true;
    }
    */

    // light up pattern can repeat and check inbetween delay if all pieces are right color 
    // then next puzzle or finish and setactive(true) for ingredients

    void SetIngredientsActive()
    {
        if (CompletedPuzzle == true)
        {
            foreach(GameObject ing in ings)
            {
                ing.SetActive(true);
            }
            hand.SetActive(true);
            medpack.SetActive(true);
        }
    }
    
    void Reset()
    {
        time = 10.0f;
    }

    void ResetAllTimes()
    {
        time = 10.0f;
        time2 = 10.0f;
        time3 = 10.0f;
    }

    //void
}