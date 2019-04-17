using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MoveBitchMove : MonoBehaviour
{
	public UnityEvent OnGrounded, OffGrounded;
	public int Speed = 5;
	public float Gravity = 10f;
	public float JumpForce = 2f;

	public CharacterController controller;
	private Vector3 position;


	void Start()
	{
		controller = GetComponent<CharacterController>();
	}


	void Update()
	{
		if (controller.isGrounded)
		{
			OnGrounded.Invoke();
		}
		else
		{
			OffGrounded.Invoke();
		}

		if (controller.isGrounded && Input.GetButton("Jump"))
		{
			position.y = JumpForce*Time.deltaTime;
		}
		

//		if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
//
//		{
//			position.y = Input.GetAxis("Vertical") + Speed * Time.deltaTime;
//		}
//		else
//		{
//			position.y = Gravity * Time.deltaTime;
//		}

		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;



		controller.Move(position);
	}
}

