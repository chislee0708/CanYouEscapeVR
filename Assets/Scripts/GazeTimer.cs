using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeTimer : MonoBehaviour
{
    public float Sec = 0f;
    public Transform RadialProgress;
    public GameObject GazeToDo;
    public string Action;

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

        if(Sec >= 1f)
        {
            GazeMove();
        }
    }

    public void Resetinator()
    {
        Sec = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = Sec;
    }

    public void GazeMove()
    {

        if (Action == ("HAND"))
        {
            GazeToDo.GetComponent<NodeMaster>().InHands();
        }
        else if (Action == ("NODE"))
        {
            Resetinator();
            GazeToDo.GetComponent<NodeMaster>().OnNodes();
        }
    }
}
