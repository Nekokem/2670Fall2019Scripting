using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerStayEvent;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

}
