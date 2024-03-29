﻿using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
}
