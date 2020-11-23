using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGeneration : MonoBehaviour
{
    public GameObject ringToSpred;
    public GameObject boxToSpred;
    public GameObject boxLongToSpred;
    public int NumRing;
    public int Numbox;
    public int NumboxLong;

    public float itemXSpread = 10;
    public float itemYSpread = 10;
    public float itemZSpread = 10;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Numbox; i++)
        {
            SpreadBoxes();
        }

        for (int i = 0; i < NumboxLong; i++)
        {
            SpreadBoxesLong();
        }

        for (int i = 0; i < NumRing; i++)
        {
            
            SpreadRings();
        }

    }

    // Update is called once per frame
    void SpreadBoxes()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread));
        GameObject cloneBox = Instantiate(boxToSpred, randPosition, Quaternion.identity);
    }

    void SpreadBoxesLong()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread));
        GameObject cloneBoxLong = Instantiate(boxLongToSpred, randPosition, Quaternion.identity);
    }

    void SpreadRings()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread));
        GameObject cloneRing = Instantiate(ringToSpred, randPosition, Quaternion.identity);
    }

}
