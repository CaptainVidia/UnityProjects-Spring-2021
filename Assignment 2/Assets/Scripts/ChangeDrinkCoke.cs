/* 
 * George Tang 
 * ChangeDrinkCoke.cs 
 * Assignment 2
 * Changes the drink to coke to serve
 */
using UnityEngine;
using System.Collections;

namespace StrategyPatternWithScriptableObjects
{
    [CreateAssetMenu]
    public class ChangeDrinkCoke : ChangeDrinkType
    {
        public override void ChangeDrink(GameObject drink)
        {
            Debug.Log("Drink changed to Coke");
            drink.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}
