using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftBox : MonoBehaviour
{
    public bool isComplete = false;
    // List for ingredient tags
    public List<string> ingTags = new List<string>(); //GameObject.tag is string
    //public Material[] materials; // need to see if can access material by name instead as will break script otherwise
    //Renderer rend;
    public GameObject[] ings = new GameObject[5]; // arr for ingredients

    // Start is called before the first frame update
    void Start()
    {
        //rend = GetComponent<Renderer>();
        //rend.enabled = true;
        //rend.sharedMaterial = materials[0]; // materials or ???


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // adding and deletig item func, may just need to use modififed drop from drop and grab to alsoe delete item


    // item check func
    // node master script for item?
    /*bool ItemChosen()// (item player is holding)
    {
        bool itemAdded = OnCollisionsEnter(item);
        return itemAdded;
    }
    */

    // Used for adding items to craftbox
    void OnCollisionsEnter(Collision col)
    {
        if (col.GameObject.tag == "ing1" || col.GameObject.tag == "ing2" || col.GameObject.tag == "ing3" || col.GameObject.tag == "ing4" || col.GameObject.tag == "ing5")
        {
            Debug.Log("Added " + col.GameObject.tag); // test script
            ingTags.Add(col.GameObject.tag);
            string tag = col.GameObject.tag;
            char c = tag[3];
            int objectNum = (int)(c-'0'); // makes tag ing num an integer for ings array purposes
            objectNum -= 1; // allligns ing# with array pos
            ings[objectNum].SetActive(false); // makes corresponding ingredient objcet invisible?
            // Remove obj material (make obj invisible and send it to outside room loc) ?
            // rend.sharedMaterial = material[0]; //??? remove and make invisible? 
            // May not be nescessary to move obj ing until rresetting and then setactive true
            int numOfIngs = ingTags.Capacity; 
            if (numOfIngs > 2) // 3 ings to make medpack 
            {
                isComplete = transformCraftbox();     
                if (isComplete = true)
                {
                    // Exit and end puzzle
                }
                else // puzzle is not solved
                {
                    Reset();
                }
            }
        }            
    }


    bool transformCraftbox() 
    {
        string combination = "";
        foreach(var ing in ingTags)
        {
            combination += ing;
        }
        if(combination == "ing1ing2ing3")
        {
            return true;
        }
        // possible other combos can be put here
        else
        {
            return false;
        }
    }
    /*
    bool completePuzzle(Collision col)
    {
        // use list combo to determine if correct else call reset 
    }
    */

    // reset items and start agin func
    void Reset()
    {
        resetIngredients();
        // reset craftbox 
    }

    void resetIngredients()
    {
        // reset all ingredients func?
        // how will it restore item's scripts?
        // Add obj original material
        // at end just move ings to vector pointsthey were at originally
        // reset ingredient obj list
        ingTags.Clear(); // clears list of ings
        // transform.GameObject 
        for(int i = 0; i < 5; i++) // makes ingredients reappear
        {
            ings[i].SetActive(true);
        }    
    }

}
// way to possibly destroy object
/*
void Update()
    {
        float rightClick = player_Input.Player.mouseClick.ReadValue<float>();

        Ray point = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;

        if (Physics.Raycast(point, out hit))
        {
            if(hit.transform.tag == "Fence")
            {
                Destroy(hit.transform.GameObject);
            }
        }

        if(rightClick > 0)
        {
            Debug.Log("Right button has been clicked");
        }
    }
*/
