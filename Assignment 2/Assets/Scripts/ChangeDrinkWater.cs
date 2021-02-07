/* 
 * George Tang 
 * ChangeDrinkWater.cs 
 * Assignment 2
 * Changes the drink to water to serve
 */
using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{
    [CreateAssetMenu]
    public class ChangeDrinkWater : ChangeDrinkType
    {
        public override void ChangeDrink(GameObject drink)
        {
            Debug.Log("Drink changed to Water");
            drink.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

    }
}
