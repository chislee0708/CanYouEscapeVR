using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

    public class MultiNodeMaster : MonoBehaviour
    {
        public Rigidbody[] GazeObjects = new Rigidbody[5]; // ings 
        public GameObject[] ingredients = new GameObject[5];// ings
        public Transform Holder;
        //public MeshRenderer MeshRend;
        // public GameObject TheNodes;
        //public RaycastHit hit;
        public GameObject CraftBox;
        public Color col;
       // private Renderer rend;
        public int x = 1;
        
        
        // Tried to use raycasting to selecet ingredient for gazetimer but didn't work after many attempts to modify it
        // Impleemnted puzzle via color change instead and incrementing
        //private float distance = 1.5f; //0.5f
        //private float yOffset = 0.5f;
        //private float playerRadius = 0.3f;
    
        public float timeLeft = 15.0f; // for now uses a timer to switch beetenn objects taht player can hold randomly
        //public Rigidbody GazeObjects[i] = Objects[Random.Range(0, 4)];
        // will try to implement line of sight perhpas if workaround works
        // public Rigidbody GazeObjects[i] = Objects[i]; 

            //public static System.Random random = new System.Random();
            //public int Num = random.Next(0, 2);

      
        void Start()
        {
            col = GetComponent<Renderer>().material.color = Color.red;
            //rend.material.color = Color.red;
        }    
            

        void Update()
        {   
            /*while(timeLeft > 0)
            {    
                timeLeft -= Time.deltaTime;
            }*/
            timeLeft -= Time.deltaTime;
            if(timeLeft <= 0)
            {
                //ingredients[x-1].GetComponent<Renderer>().material.color = GetComponent<Renderer>().material.color;
                ingredients[x].GetComponent<Renderer>().material.color = col;
                ChangeVal();
                ChooseIngredient();
                Debug.Log("Ingredient " + x + " can be added");
            }
            
        }

        void ChooseIngredient()
        {
                //GetComponent<Renderer>().material.color = ingredients[x-1].GetComponent<Renderer>().material.color;
                col = ingredients[x].GetComponent<Renderer>().material.color;
                ingredients[x].GetComponent<Renderer>().material.color = Color.red;
        }

        void ChangeVal()
        {
            if(x >= 5)
            {
                x = 0;
            }
            else
            {
                x += 1;
            }
            timeLeft = 20.0f;
        }
            
            /*
            List<RaycastHit> allHits = new List<RaycastHit>();
            DetectGround(allHits, Vector3.zero);

            const int rays = 10;
            for (int i = 0; i < rays; ++i)
            {
                float angle = (360.0f / rays) * i;
                Vector3 posOffset = Quaternion.AngleAxis(angle, Vector3.up) * (Vector3.forward * playerRadius);

                DetectGround(allHits, posOffset);
            }

            if (allHits.Any())
            {
                RaycastHit closestHit = allHits.OrderBy(hit => hit.distance).First();
                OnFound(closestHit.collider.tag);
            }
            */
              

        /*
        void OnFound(string tag)
        {
            
            
            if(tag == "Ground")
            {
                Debug.Log ("Player is standing on the ground");
            }
            else if(tag == "Platform")
            {
                Debug.Log ("Player is standing on the platform");
            }
            
            if(tag == "ing1" || tag == "ing2" || tag == "ing3" || tag == "tag4" || tag == "ing5")
            {
                char c = tag[3];
                Debug.Log("ing " + c + " chosen ");
                int objectNum = (int)(c - '0'); // makes tag ing num an integer for ings array purposes
                objectNum -= 1;
                x = objectNum;
            }
        }

        void DetectGround(List<RaycastHit> hits, Vector3 posOffset)
        {
            Ray footstepRay = new Ray(transform.position + posOffset + (Vector3.up * yOffset), Vector3.down); // FIX: added an offset

            // Debug.DrawLine(footstepRay.origin, footstepRay.origin + (footstepRay.direction * (distance + yOffset)), Color.red);
            hits.AddRange(Physics.RaycastAll(footstepRay, distance + yOffset, LayerMask.GetMask("ing1", "ing2", "ing3", "ing4", "ing5")));
        }

        */

        public void InHands()
        {
            if(x != null )
            {
                GazeObjects[x].transform.parent = Holder.transform;
                GazeObjects[x].transform.localPosition = Holder.transform.localPosition;

                //TheNodes.SetActive(true);

                GazeObjects[x].transform.parent = null;
                GazeObjects[x].transform.localPosition = CraftBox.transform.localPosition;
            }
        }

        
        /*
        public void OnNodes()
        {
            GazeObjects[i].transform.parent = null;
            GazeObjects[i].transform.localPosition = Holder.transform.localPosition;

            TheNodes.SetActive(false);
        }
        */

        /*
        public void changeObject()
        {
            //i = GazeObjects[Random.Range(0, 4)];
            i = random.Next(0, 4); //GazeObjects.length
        }
        */

        /*
        public void CountDown()
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                changeObject();
                timeLeft = 20.0f;
            }
        }
        */




            /*
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
            */

    }

