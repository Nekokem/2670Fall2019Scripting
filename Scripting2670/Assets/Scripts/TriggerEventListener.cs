using UnityEngine;
using UnityEngine.Events;

public class TriggerEventListener : MonoBehaviour, IListen
{
    public Object IRunObj;
    public UnityEvent Event { get; set; }
    public IRun newIRunObj { get; set; }
    public void Start()
    {
        Event = new UnityEvent();
          newIRunObj = IRunObj as IRun; 
                Event.AddListener(newIRunObj.Run);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
        Event.RemoveListener(newIRunObj.Run);
    }
}
