using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    
    // add script to hand
    public class AddIngredients : MonoBehaviour
    {
        public Rigidbody GazeObject; // =  //Rigidbody[] GazeObjects = new Rigidbody[5]; // ings 
        //public Transform Holder;
        public GameObject CraftBox;
        public GameObject TheNodes;
    }
    /*
        // public float timeLeft = 20.0f; // for now uses a timer to switch beetenn objects taht player can hold randomly
        // public Rigidbody GazeObjects[i] = Objects[Random.Range(0, 4)];
        // will try to implement line of sight perhpas if workaround works
        // public Rigidbody GazeObjects[i] = Objects[i]; 

        //public class Program
        //{
           // public static System.Random random = new System.Random();
           //  public int i = random.Next(0, 4);
        //}

        public void TransferIngredient()
        {
            GazeObject.transform.parent = null;
            GazeObject.transform.localPosition = Craftbox.transform.localPosition;
            //GazeObjects[i].transform.localPosition = Holder.transform.localPosition;


        }

    public float Sec = 0f;
    public Transform RadialProgress;
    public GameObject GazeToDo;
    public string Action;
    public RaycastHit hit; 
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

            //GazeToDo.GetComponent<NodeMaster>().InHands();
        }


/*


        void Update()
        {
            //CountDown();
        }

        public void TransferIngredient()
        {
            GazeObject.transform.parent = null;
            GazeObject.transform.localPosition = Craftbox.transform.localPosition;
            //GazeObjects[i].transform.localPosition = Holder.transform.localPosition;


        }

        public void InHands()
        {
            //GazeObjects[i].transform.parent = Holder.transform;
            //GazeObjects[i].transform.localPosition = Holder.transform.localPosition;

            TheNodes.SetActive(true);

        }

        public void OnNodes()
        {
            //GazeObjects[i].transform.parent = null;
            //GazeObjects[i].transform.localPosition = Holder.transform.localPosition;

            //TheNodes.SetActive(false);
        }

        public void changeObject()
        {
            //i = GazeObjects[Random.Range(0, 4)];
            //i = random.Next(0, 4); //GazeObjects.length
        }

        public void CountDown()
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                changeObject();
                timeLeft = 20.0f;
            }
        }


            
            public void ObjectChosen()
            {
                Vector3 directionToTarget = Holder.transform.position - GazeObjects[i]s[i].position;
                float angle = Vector3.Angle(transform.forward, directionToTarget);
                float distance = directionToTarget.magnitude;

                if (Mathf.Abs(angle) < 90  distance < 10)
                {
                     Debug.Log("target is in front of me");
                }
            }
            

    }
*/
