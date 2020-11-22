using UnityEngine;

public class HandGunToggle : MonoBehaviour
{
    public int status;  //0 = hand, 1 = gun

    // Start is called before the first frame update
    void Start()
    {
        status = 0;
        Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Select()
    {   
        int i = 0;
        foreach (Transform handgun in transform)
        {
            if( i == status)
            {
                Debug.Log(handgun.gameObject.name + " Activated");
                handgun.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log(handgun.gameObject.name + " Deactivated");
                handgun.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
