/* 
 * George Tang 
 * ChangeDrinkCoffee.cs 
 * Assignment 2
 * Changes the drink to coffee to serve
 */
using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{
    [CreateAssetMenu]
    public class ChangeDrinkCoffee : ChangeDrinkType
    {
        public override void ChangeDrink(GameObject drink)
        {
            Debug.Log("Drink changed to Coffee");
            drink.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }
}
