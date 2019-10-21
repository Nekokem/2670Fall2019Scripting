using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{

    public GameAction gameActionobj;

    public VectorThreeData instanceLocation;
    public void InstanceObj(GameObject obj)
    {
        var newOBJ = Instantiate(obj, instanceLocation.value, Quaternion.identity);
        gameActionobj.transformAction(newOBJ.transform);
    }
}
