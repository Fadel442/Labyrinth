using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 0)
        {
            return;
        }       

        var touch = Input.GetTouch(0);
        Debug.Log(touch.phase);
    }
}
