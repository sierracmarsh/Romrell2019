using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour {
	public UnityEvent StartEvent, KeyDownEvent, MouseDownEvent, UpdateEvent;
	// Use this for initialization
	public void start() {
		
		StartEvent.Invoke();
	}


	public void OnKeyDown()
	{
		KeyDownEvent.Invoke();
	}
	
	

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}


	public void Update () {
		UpdateEvent.Invoke();
	}
}
