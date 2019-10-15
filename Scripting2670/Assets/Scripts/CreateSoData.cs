using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSoData : MonoBehaviour
{
    public IntData data;
    private  IntData newData;
    void Start()
    {
        newData = Instantiate(data);
    }
    
}
