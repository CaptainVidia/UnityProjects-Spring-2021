using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{

    public class BeverageCoke : Beverage, Serve
    {
        
        public void Awake()
        {
            
            ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkCoke>();

        }

        public override void Serve()
        {
            Debug.Log("Drink Coke has been served.");
            Destroy(gameObject);
        }
    }
}

