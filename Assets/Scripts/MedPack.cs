using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    public float timer = 5f;
    public float timer2 = 40f;
    public bool IsComplete = false;
    public bool FinishedPuzzle = false;
    public GameObject[] ingredients = new GameObject[5];
    public GameObject key; // key's boolean value will be unlocked?
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
         //this.transform.position = new Vector3(2f, 2f, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {   
        timer2 -= Time.deltaTime;
        if(timer2 <= 0f)
        {
        this.transform.position = new Vector3(2f, 1.5f, 4.5f);
            if(this.transform.position == new Vector3(2f, 1.5f, 4.5f));
            {
                FinishedPuzzle = true;
                RemoveIngredients(FinishedPuzzle);
                timer -= Time.deltaTime;
                if(timer <= 0f)
                {
                    //boolean.GetComponent<Boolean>().Set(FinishedPuzzle);
                    GameObject.Destroy(this.gameObject);
                    door.SetActive(false);
                    
                }
            }
        }
        
    }

    void RemoveIngredients(bool IfTrue)
    {
        if(IfTrue)
        {
            for(int i = 0; i < 5; i++)
            {
                ingredients[i].SetActive(false);
            }
        }
    }
}