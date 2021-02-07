using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{

    public class BeverageWater : Beverage, Serve
    {

        public void Awake()
        {

            ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkWater>();

        }

        public override void Serve()
        {
            Debug.Log("Drink Water has been served.");
            Destroy(gameObject);
        }
    }
}
