using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitCount : MonoBehaviour
{
    //playerHitCount tracks the number of times the player has been hit by a "laser"
    public int playerHitCount;
    // Start is called before the first frame update
    void Start()
    {
        playerHitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHitCount == 10)
        {   
            //Player dies after being hit 10 times and is brought to the Level Failed Screen
            //SceneManager.LoadScene("Maze Menu");
        }
    }

    public void incrementCount(){
        playerHitCount++;
    }
}
