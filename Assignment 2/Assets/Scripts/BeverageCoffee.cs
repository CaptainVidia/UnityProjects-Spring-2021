using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{

    public class BeverageCoffee : Beverage, Serve
    {

        public void Awake()
        {

            ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkCoffee>();

        }

        public override void Serve()
        {
            Debug.Log("Drink Coffee has been served.");
            Destroy(gameObject);
        }
    }
}
