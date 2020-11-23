using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMove : MonoBehaviour
{
    public bool canMove = true;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Vector3 cameraForward = Camera.main.transform.forward;
            this.gameObject.transform.Translate(cameraForward * Time.deltaTime * speed);

        }
    }
}
