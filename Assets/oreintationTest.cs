using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oreintationTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsAccelerometer)
        {
            Debug.Log("accel");
        }
        if (SystemInfo.supportsGyroscope)
        {
            Debug.Log("gyro");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
