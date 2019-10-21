
using UnityEngine;


public class CharacterMover : ScriptableObject
{
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    private Vector3 position;
    public IntData jumpDataObj;
    
    public void MoveCharacter(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;
        
        if (Input.GetButtonDown("Jump") && jumpDataObj.value < jumpDataObj.maxValue)
        {
            position.y = jumpSpeed;
            jumpDataObj.value++;
        }

        else if (controller.isGrounded)
        {
            position.y = 0;
        }

        controller.Move(position * Time.deltaTime);
    }
}
