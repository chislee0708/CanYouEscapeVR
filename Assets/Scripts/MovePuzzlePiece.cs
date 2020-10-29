using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePuzzlePiece : MonoBehaviour
{   

    public GameObject puzzlePiece;
    public GameObject playerHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            puzzlePiece.transform.SetParent(playerHand.transform);
            puzzlePiece.transform.localPosition = new Vector3(0f, -0.4f, 0f);
        }
    }
}
