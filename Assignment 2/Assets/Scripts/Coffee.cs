using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : Beverages
{
    void Awake()
    {
        serveDrinkBehavior = gameObject.AddComponent<CoffeeLiquid>();

    }
}
