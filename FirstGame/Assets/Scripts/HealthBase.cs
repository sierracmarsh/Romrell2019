using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
	public class HealthBase : ScriptableObject
	{
		public int Value = 5;
   

		public void OnHealth(int addValue)
		{
			Value += addValue;
		}
	}


