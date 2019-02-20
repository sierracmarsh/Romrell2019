
using UnityEngine;
using UnityEngine.Events;

public class deathwheelevent : MonoBehaviour
{
	public UnityEvent Event;


	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}

	}

