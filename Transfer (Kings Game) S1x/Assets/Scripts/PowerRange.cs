using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerRange : MonoBehaviour
{

	[CreateAssetMenu]
	public class PowerUpBase : ScriptableObject
	{
		public float Value = -3f;


		public void OnPowerup(float addValue)
		{
			Value += addValue;
		}
	}
}
