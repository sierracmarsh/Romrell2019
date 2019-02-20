using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class Mouse1 : Animal
{
	public Color Tail;
	public int Fur = 10000;
	public float TailSpeed = 0.4f;
	public bool CanEat = true;
	public UnityEvent ColorEvent;
	


	// Use this for initialization
	void Start()
	{
		ColorEvent.Invoke();



		// Update is called once per frame
	}
}
