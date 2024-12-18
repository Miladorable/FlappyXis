using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControler : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbodyControl;
    [SerializeField]
    private float jumpForce = 1f;
    [SerializeField]
    private Animator animator;


    public void Jump(InputAction.CallbackContext context)
    {
        rigidbodyControl.velocity = Vector3.zero;
        rigidbodyControl.AddForce(transform.up * jumpForce);
        
    }

   // private string TriggerJump;
    //{
        
    //}
}
