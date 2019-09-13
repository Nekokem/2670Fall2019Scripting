using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{


    public UnityEvent handlerEvent;
    public GameAction gameActionObj;

    public IfStatments ifStatmentsObj;
    // Start is called before the first frame update
    void Start()
    {
        gameActionObj.action += Action;
        ifStatmentsObj.Test += Action;
    }

    private void Action()
    {
    
        handlerEvent.Invoke();
        
    }
}
