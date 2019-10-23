using UnityEngine;

[CreateAssetMenu]
public class MoveHVArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }
    public Vector3 newLocation;


    public void Move(CharacterController controller)
    {
        newLocation.y = Input.GetAxis("Horizontal");
        controller.Move(newLocation);
    }
}
