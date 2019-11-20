using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.activeSelf == true)
        if (gameObject.activeInHierarchy == true)
        {
            Debug.Log("alive");
        }
        else if (gameObject.activeInHierarchy == false)
        {
            Debug.Log("dead");
        }
        else {
            Debug.Log("ascended");
        }
    }
}
