using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeMedPack : MonoBehaviour
{
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;
    // bool to be used in light pattern color to determine if piece was changed color at all
    public bool changedColor = false;
    public Transform RadialProgress;

    // Use this for initialization
    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = timer;
    }

    // Update is called once per frame
    void Update()
    {

        if (gazedAt)
        {   
            timer += Time.deltaTime;
            RadialProgress.GetComponent<Image>().fillAmount = timer;
            GameObject.Destroy(this.gameObject);
            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }

    }

    public void Resetinator()
    {
        timer = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = timer;
    }

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }

    //

    public bool ChangedColor()
    {
        return changedColor;
    }

    public void ResetChangedColor()
    {
        changedColor = false;
    }

}