using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Weapons : MonoBehaviour {
	public UnityEvent FiringEvent, PowerFireEvent, EmptyAmmoEvent;


	public enum States
	{
		Firing,
		PowerFire,
		EmptyAmmo,
		
	}

	public States CurrentState;
	
	
	
	void Update () 
	{
		switch (CurrentState)
		{
			case States.Firing:
				FiringEvent.Invoke();
				break;
			case States.PowerFire:
				PowerFireEvent.Invoke();
				break;
			case States.EmptyAmmo:
				EmptyAmmoEvent.Invoke();
				break;
			
			
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
