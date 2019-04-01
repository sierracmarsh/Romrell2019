using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
			case States.Starting:
				FiringEvent.Invoke();
				break;
			case States.Playing:
				PowerFireEvent.Invoke();
				break;
			case States.Dying:
				EmptyAmmoEvent.Invoke();
				break;
			
			
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
