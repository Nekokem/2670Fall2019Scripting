using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameClass : MonoBehaviour
{

    public GameAction gameActionobj;
    public void OnMouseDown()
    {
        gameActionobj.Raise();
    }
}
