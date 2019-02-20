using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{

	public string Name;

	public FloatData Health;
	public FloatData Speed;
	public bool CanMove;

	public Color SkinColor;
	public Color SkinChange;
	
	public UnityEvent Chara;


	private void OnCollisionEnter2D()
	{
		Chara.Invoke();
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
