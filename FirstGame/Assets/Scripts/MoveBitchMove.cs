using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MoveBitchMove : MonoBehaviour
{
    public UnityEvent OnGrounded, OffGrounded;
	public int Speed = 3;
	
	public CharacterController controller;
	private Vector3 position;

	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	
	void Update ()
	{
        if(controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }
        position.y = Input.GetAxis("Vertical") + Speed * Time.deltaTime;

        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		
		
		controller.Move(position);
	}
}
