using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePuzzlePiece : MonoBehaviour
{   

    public GameObject puzzlePiece;
    public GameObject playerHand;
    bool inHands = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {   
            if(!inHands) {
                inHands = true;
                puzzlePiece.transform.SetParent(playerHand.transform);
                puzzlePiece.transform.localPosition = new Vector3(0f, -0.4f, 0f);
            } else if ( inHands ){
                inHands = false;
                puzzlePiece.transform.SetParent(null);
                puzzlePiece.transform.localPosition = puzzlePiece.transform.position;
            }
        }
    }
}
