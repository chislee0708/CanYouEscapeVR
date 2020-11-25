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
        Select();
    }

    void Select()
    {   
        int i = 0;
        foreach (Transform handgun in transform)
        {
            if( i == status)
            {
                handgun.gameObject.SetActive(true);
            }
            else
            {
                handgun.gameObject.SetActive(false);
            }
            i++;
        }
    }

    //This will allow Player to toggle between Gun and Hand immediately
    public void ChangeStatus()
    {
        if(status == 0)
        {
            status = 1;
        } 
        else
        {
            status = 0;
        }
    }
}
