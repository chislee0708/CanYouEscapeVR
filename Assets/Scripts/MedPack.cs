using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    public float timer = 20f;
    public float timer2 = 40f;
    public bool IsComplete = false;
    public bool FinishedPuzzle = false;
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
         this.transform.position = new Vector3(2f, 2f, 4.5f);
        if(this.transform.position == new Vector3(2f, 2f, 4.5f));
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                GameObject.Destroy(this.gameObject);
                FinishedPuzzle = true;
            }
        }
        }
        
    }
}