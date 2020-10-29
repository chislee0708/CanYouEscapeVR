using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMaster : MonoBehaviour
{
    public Rigidbody GazeObject;
    public Transform Holder;
    public GameObject TheNodes;

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



}
