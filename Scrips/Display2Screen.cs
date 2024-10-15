using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display2Screen : MonoBehaviour
{    void Start()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
    }
}
