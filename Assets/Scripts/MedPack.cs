using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    public float timer = 20f;
    public bool IsComplete = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position == new Vector3(2f, 2f, 4.5f))
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
        
    }
}