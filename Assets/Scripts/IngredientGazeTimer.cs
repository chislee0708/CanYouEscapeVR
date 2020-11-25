using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientGazeTimer : MonoBehaviour
{
    public float Sec = 0f;
    public Transform RadialProgress;
    public GameObject GazeToDo;
    public string Action;
    //public GameObject CraftBox; // craftbox loc purposes
    //public Rigidbody[] GazeObjects = new Rigidbody[5];

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
            GazeToDo.GetComponent<MultiNodeMaster>().InHands(); // object will be chosen from nodemaster
            // get tag from MNM.cs with above func?
            //for(int i = 0; i < 5; i++)
            //{
              //  if(GazeObjects[i] == )
                //{
                  //  GazeObjects[i].transform.position = CraftBox.transform.position;
              //  }
            //}
            Resetinator();

        }
        else
        {
             Resetinator();
        }
        /*
        else if (Action == ("NODE"))
        {
            Resetinator();
            GazeToDo.GetComponent<NodeMaster>().OnNodes();
        }
        */
    }
}
