using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;
    public UnityEvent UpdateImageEvent;
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent(float amount)
    {
        imageComponent.fillAmount += amount;
    }

    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillamount = dataObj.value;
    }
    
    private void Update()
    {
        UpdateImageEvent.Invoke();
    }
}
