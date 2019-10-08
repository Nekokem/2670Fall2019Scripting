using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Object> objectList;
    
    
    public List<FloatData>FloatDataList;

    public List<GameObject> GAmeObjectList;

    public void FindObjectType(Object obj)
    {
        foreach (var currentOBJ in objectList)
        {
            if (currentOBJ == obj)
            {
                //DO WORK;
            }
        }

    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentOBJ in objectList)
        {
            if (currentOBJ == obj)
            {
                objectList.Remove(obj);
            }
        }
    }
}
