using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MultipleNodeMasters : MonoBehaviour
    {
        public Rigidbody[] Objects = new Rigidbody[5]; // ings 
        public Transform Holder;
        public GameObject TheNodes;
        Random random = new Random();
        public int i = random.Next(0, Objects.length);
        public float timeLeft = 20.0f; // for now uses a timer to switch beetenn objects taht player can hold randomly
        public Rigidbody GazeObject = Objects[Random.Range(0, 4)];
        // will try to implement line of sight perhpas if workaround works
        // public Rigidbody GazeObject = Objects[i]; 

        void Update()
        {
            CountDown();
        }

        public void InHands()
        {
            GazeObject.transform.parent = Holder.transform;
            GazeObject.transform.localPosition = Holder.transform.localPosition;

            TheNodes.SetActive(true);

        }

        public void OnNodes()
        {
            GazeObject.transform.parent = null;
            GazeObject.transform.localPosition = Holder.transform.localPosition;

            TheNodes.SetActive(false);
        }

        public void changeObject()
        {
            GazeObject = Objects[Random.Range(0, 4)];
            //i = random.Next(0, Objects.length)
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
                Vector3 directionToTarget = Holder.transform.position - GazeObjects[i].position;
                float angle = Vector3.Angle(transform.forward, directionToTarget);
                float distance = directionToTarget.magnitude;

                if (Mathf.Abs(angle) < 90  distance < 10)
                {
                     Debug.Log("target is in front of me");
                }
            }

    }
    */


}

