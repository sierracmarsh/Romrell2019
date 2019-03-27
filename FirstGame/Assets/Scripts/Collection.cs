using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<FloatData> CollectionList;

    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
    }

    public void AmmoInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Ammo")
            {
                Debug.Log("We have Ammo" + obj.Value + "ammo");
            }
        }
    }

    public void HurtInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Hurt")
            {
                Debug.Log("You lost" + obj.Value + "Health. Don;t let it get too low!");
            }
        }
    }


    public void FuelInfo()
    {
        // ReSharper disable once EmptyForStatement
        for (
            int i = 0;
            i < 10;
            i++)
            if (CollectionList[i].name == "Fuel")
        {
            Debug.Log(CollectionList[i]);
        }
    }

}


        
        
            
                
    
    
