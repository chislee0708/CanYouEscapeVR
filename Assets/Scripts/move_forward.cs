using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class move_forward : MonoBehaviour
{
    public Text countText;
    public GameObject failText;
    public GameObject winText;
    public AudioSource soundCrash;
    public AudioSource soundPickUp;
    public AudioSource bgMusic;
    public int count;
    private bool hasCollide = false;


    // initialization
    void Start()
    {
        count = 0;
        failText.SetActive(false);
        winText.SetActive(false);
        soundPickUp.Stop();
        soundCrash.Stop();
        bgMusic.Play();
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.CompareTag("pickUp")) // if collided with frames
        {
            otherObject.gameObject.SetActive(false);
            count++;
            soundPickUp.Play();
        }
        else if (otherObject.gameObject.CompareTag("stopper")) // if collided with red boxes
        {
           
            if (hasCollide == false)
            {
                hasCollide = true;
                GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false; //stop moving
                soundCrash.Play();
                failText.SetActive(true);
            }
        }
        else if (otherObject.gameObject.CompareTag("finish"))
        {
            GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false; //stop moving
            GameObject.Find("Finish").SetActive(false);
            if (count >= 10)
            {
                
                GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false; //stop moving
                winText.SetActive(true); // show win text and menu
                GameObject.Find("Finish").SetActive(false);
            } else
            {
                failText.SetActive(true); // show game over text and menu
            }
            
            
        }
    }

}
