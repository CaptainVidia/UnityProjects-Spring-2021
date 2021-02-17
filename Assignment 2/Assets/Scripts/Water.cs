using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Beverages
{
    void Awake()
    {
        serveDrinkBehavior = gameObject.AddComponent<WaterLiquid>();

    }
}
