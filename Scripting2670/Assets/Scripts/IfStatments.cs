using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IfStatments : MonoBehaviour
{
    private float brainFunctionLevel = 75f;
    private float overLoadLevel = 100f;
    private float notInUseLevel = 25f;

    public UnityAction Test;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            LevelTest();

        brainFunctionLevel += Time.deltaTime * 15f;

    }

    void LevelTest()
    {

        if (brainFunctionLevel > overLoadLevel)
        {

            print("Can't function.");
        }
        
        else if (brainFunctionLevel < notInUseLevel)
        {
            print("Brain is asleep.");
        }

        else
        {
            print("Functioning.");
        }
    }
}
