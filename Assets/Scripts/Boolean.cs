using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolean : MonoBehaviour
{
    public bool IsDone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Set(bool val)
    {
        this.IsDone = val;
    }

    bool Get()
    {
        return this.IsDone;
    }
}
