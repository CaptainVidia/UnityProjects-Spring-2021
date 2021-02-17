using UnityEngine;
using System.Collections;


    public class Soda : Beverages
    {
        void Awake()
        {
            serveDrinkBehavior = gameObject.AddComponent<SodaLiquid>();

        }

    }

