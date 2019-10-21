using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CiniMachineController : MonoBehaviour
{
    public GameAction gameActionobj;
    private CinemachineVirtualCamera virtualCamera;
    void Start()
    {
        gameActionobj.transformAction = TransformHandler;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void TransformHandler(Transform transforobj)
    {
        virtualCamera.Follow = transforobj;
    }
}
