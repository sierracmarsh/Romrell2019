using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AniChara : Animal
{
	public UnityEvent Event;

	// Use this for initialization
	void Start () {
		 Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
