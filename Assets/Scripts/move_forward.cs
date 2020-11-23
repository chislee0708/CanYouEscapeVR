using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



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


    // Use this for initialization
    void Start()
    {
        count = 0;
        failText.SetActive(false);
        winText.SetActive(false);
        soundPickUp.Stop();
        soundCrash.Stop();
        bgMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.CompareTag("pickUp"))
        {
            otherObject.gameObject.SetActive(false);
            count++;
            soundPickUp.Play();
        }
        else if (otherObject.gameObject.CompareTag("stopper"))
        {
           
            if (hasCollide == false)
            {
                hasCollide = true;
                GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false;
                soundCrash.Play();
                failText.SetActive(true);
            }
        }
        else if (otherObject.gameObject.CompareTag("finish"))
        {
            GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false;
            GameObject.Find("Finish").SetActive(false);
            if (count >= 10)
            {
                
                GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false;
                winText.SetActive(true);
                GameObject.Find("Finish").SetActive(false);
            } else
            {
                failText.SetActive(true);
            }
            
            
        }
    }

}
