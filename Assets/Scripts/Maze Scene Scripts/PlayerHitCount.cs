using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitCount : MonoBehaviour
{
    public int playerHitCount;
    // Start is called before the first frame update
    void Start()
    {
        playerHitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHitCount == 10){
            SceneManager.LoadScene("Maze Menu");
        }
    }

    void OnTriggerEnter(Collider collidedObj)
    {
        playerHitCount++;
        Debug.Log("Player Hit: " + playerHitCount);
    }
}
