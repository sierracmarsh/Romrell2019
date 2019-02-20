using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    public float Value = 10.5f;
   

    public void OnPowerup(float addValue)
    {
        Value += addValue;
    }
}
