using UnityEngine;

[CreateAssetMenu]
public class DoDamage : ScriptableObject, IRun
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("Done did damage!");
    }

    public void Run(float f)
    {
        throw new System.NotImplementedException();
    }
}
