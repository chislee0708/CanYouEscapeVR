using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConroller : MonoBehaviour
{
    private int nextScenceLoad;

    private void Start()
    {
        nextScenceLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextScenceLoad);
    }
}
