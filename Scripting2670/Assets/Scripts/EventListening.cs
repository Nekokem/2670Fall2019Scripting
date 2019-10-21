using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour, IListen
{
    
    public UnityEvent Event { get; set; }
    public Object IRunobj;
    public IRun newIRunObj { get; set; }

    public void Start()
    {
        Event = new UnityEvent();
        newIRunObj = IRunobj as IRun; 
        Event.AddListener(newIRunObj.Run);
    }
    

    private void OnMouseDown()
    {
        Event.Invoke();
        Event.RemoveListener(newIRunObj.Run);
    }

}
