using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class move_forward : MonoBehaviour
{
    //public float speed = 10f;
    //public bool canMove = true;
    public Text countText;
	public Text gameOverText;
	public Text instructionText;
	public Text winText;
    public ParticleSystem effect;
    public bool isImgOn;
    public Image img;
    public AudioSource soundWind;
    public AudioSource soundCrash;
    public AudioSource soundPickUp;
    private int count;
    private bool hasCollide = false;


    // Use this for initialization
    void Start()
    {
        effect.Stop();
        count = 0;
        SetCountText();
		gameOverText.text = "";
		instructionText.text = "";
		winText.text = "";
        img.enabled = false;
        isImgOn = false;
        soundWind.Play();
        soundPickUp.Stop();
        soundCrash.Stop();

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
            SetCountText();
            soundPickUp.Play();
        }
        else if (otherObject.gameObject.CompareTag("stopper"))
        {
            Debug.Log("test");
            if (hasCollide == false)
            {
                hasCollide = true;
                GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false;
                Debug.Log ("test");
                soundWind.Stop();
                soundCrash.Play();
                img.enabled = true;
                isImgOn = true;
                effect.Play();
                gameOverText.text = "GAME OVER";
                instructionText.text = "Click touchpad to try again";
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Rings: " + count.ToString();
		if(count >= 2)
		{
			winText.text = "Congrats! You win!";
            img.enabled = true;
            isImgOn = true;
            GameObject.Find("Player").GetComponent<SpaceshipMove>().canMove = false;
            instructionText.text = "Click touchpad to try again";
			
		}
    }
    public void Restart()
    
    {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
