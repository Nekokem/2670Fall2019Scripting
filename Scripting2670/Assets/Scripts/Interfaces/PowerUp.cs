using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject, IRun, ITest
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("Power Up");
    }

    public void Run(float f)
    {
        throw new System.NotImplementedException();
    }

    public void Test()
    {
        Debug.Log("Power Up test.");
    }
}
