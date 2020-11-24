using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class CraftBox : MonoBehaviour
{
    public bool isComplete = false;
    // List for ingredient tags
    public List<string> ingTags = new List<string>(); //gameObject.tag is string
    //public Material[] materials; // need to see if can access material by name instead as will break script otherwise
    //Renderer rend;
    public GameObject[] ings = new GameObject[5]; // arr for ingredients
    public GameObject medpack; // for calling medpacj object at end

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

    

    // Used for adding items to craftbox
    void OnCollisionsEnter(Collision col)
    {
        //if (col.gameObject.tag == "ing1" || col.gameObject.tag == "ing2" || col.gameObject.tag == "ing3" || col.gameObject.tag == "ing4" || col.gameObject.tag == "ing5")
        // {
        Debug.Log("Added " + col.gameObject.tag); // test script
        ingTags.Add(col.gameObject.tag);
        string tag = col.gameObject.tag;
        char c = tag[3];
        int objectNum = (int)(c - '0'); // makes tag ing num an integer for ings array purposes
        objectNum -= 1; // allligns ing# with array pos
        ings[objectNum].SetActive(false); // makes corresponding ingredient objcet invisible?


        // Remove obj material (make obj invisible and send it to outside room loc) ?
        // rend.sharedMaterial = material[0]; //??? remove and make invisible? 
        // May not be nescessary to move obj ing until rresetting and then setactive true
        int numOfIngs = ingTags.Count;
        if (numOfIngs > 2) // 3 ings to make medpack 
        {
            isComplete = transformCraftbox();
            if (isComplete == true)
            {
                // make medpack object appear
                medpack.transform.position = new Vector3(2, 1, 4);
                // Destroys craftbox as puzzle is complete
                GameObject.Destroy(this.gameObject);
            }
            else // puzzle is not solved
            {
                Reset();
            }
        }
        // }
    }

    bool transformCraftbox()
    {
        string combination = "";
        foreach (var ing in ingTags)
        {
            combination += ing;
        }
        if (combination == "ing1ing2ing3")
        {
            return true;
        }
        // possible otehr combos can be put here
        else
        {
            return false;
        }
    }
  

    // reset items and start agin func
    void Reset()
    {
        resetIngredients();
        // reset craftbox 
    }

    void resetIngredients()
    {
        ingTags.Clear(); // clears list of ings
        for (int i = 0; i < 5; i++) // makes ingredients reappear
        {
            ings[i].SetActive(true);
        }
        // ings assigned to old locations 
        ings[0].transform.position = new Vector3(4.3f, 2.25f, 14.875f);
        ings[1].transform.position = new Vector3(2f, 1f, 4.829f);
        ings[2].transform.position = new Vector3(2f, 0.125f, 0.125f);
        ings[3].transform.position = new Vector3(0f, 0.125f, 0.125f);
        ings[4].transform.position = new Vector3(5.75f, 0.125f, 4f);
    }
}
*/

public class CraftBox : MonoBehaviour
{
    public bool isComplete = false;
    // List for ingredient tags
    public List<string> ingTags = new List<string>(); //gameObject.tag is string
    public GameObject[] ings = new GameObject[5]; // arr for ingredients
    public GameObject medpack; // for calling medpacj object at end
    //Random random = new Random();
    //public int i = random.Next(0, GameObject.length);

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    // Used for adding items to craftbox
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ing1") || col.gameObject.CompareTag("ing2") || col.gameObject.CompareTag("ing3") || col.gameObject.CompareTag("ing4") || col.gameObject.CompareTag("ing5"))
        //if (col.gameObject.tag == "ing1" || col.gameObject.tag == "ing2" || col.gameObject.tag == "ing3" || col.gameObject.tag == "ing4" || col.gameObject.tag == "ing5")
        {
            Debug.Log("Added " + col.gameObject.tag); // test script
            ingTags.Add(col.gameObject.tag);
            string tag = col.gameObject.tag;
            char c = tag[3];
            int objectNum = (int)(c - '0'); // makes tag ing num an integer for ings array purposes
            objectNum -= 1; // allligns ing# with array pos
            ings[objectNum].SetActive(false); // makes corresponding ingredient objcet invisible?

            // Remove obj material (make obj invisible and send it to outside room loc) ?
            int numOfIngs = ingTags.Count;
            if (numOfIngs > 2) // 3 ings to make medpack 
            {
                isComplete = transformCraftbox();
                if (isComplete == true)
                {
                    // make medpack object appear
                    medpack.transform.position = new Vector3(2f, 2f, 4.5f);
                    // Destroys craftbox as puzzle is complete
                    GameObject.Destroy(this.gameObject);
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
        foreach (var ing in ingTags)
        {
            combination += ing;
        }
        if (combination == "ing1ing2ing3" || combination == "ing1ing3ing2" || combination == "ing2ing1ing3" || combination == "ing2ing3ing1" || combination == "ing3ing1ing2" || combination == "ing3ing2ing1")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // reset items and start agin func
    void Reset()
    {
        resetIngredients();
        // reset craftbox 
    }

    void resetIngredients()
    {
        ingTags.Clear(); // clears list of ings
        for (int i = 0; i < 5; i++) // makes ingredients reappear
        {
            ings[i].SetActive(true);
        }
        // ings assigned to old locations 
        ings[0].transform.position = new Vector3(4.3f, 2.125f, 14f);
        ings[1].transform.position = new Vector3(6.5f, 2.125f, 14f);
        ings[2].transform.position = new Vector3(4.8f, 2.125f, 14f);
        ings[3].transform.position = new Vector3(3.4f, 2.125f, 14f);
        ings[4].transform.position = new Vector3(5.75f, 2.125f, 14f);

        ingTags.Clear(); // clears list of ing tags
    }
}

