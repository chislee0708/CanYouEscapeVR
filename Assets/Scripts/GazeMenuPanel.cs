using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GazeMenuPanel : MonoBehaviour
{

    public float Sec = 0f;
    public Transform RadialProgress;
    public string Button;

    // Start is called before the first frame update
    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = Sec;
    }

    // Update is called once per frame
    void Update()
    {
        Sec += Time.deltaTime;

        RadialProgress.GetComponent<Image>().fillAmount = Sec;

        if (Sec >= 1f)
        {
            Play();
        }
    }

    public void Resetinator()
    {
        Sec = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = Sec;
    }

    public void Play()
    {
        if( Button == "START")
        {
            SceneManager.LoadScene("Scene1");
        }
        else if( Button == "EXIT")
        {
            Application.Quit();
        }

    }


}
