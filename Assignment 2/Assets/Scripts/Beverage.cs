/* 
 * George Tang 
 * Beverage.cs 
 * Assignment 2
 * Abstract class for Beverages 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StrategyPatternWithScriptableObjects
{
    public abstract class Beverage : MonoBehaviour
    {
        Text restartText;
        public ChangeDrinkType ChangeDrinkType;
        public virtual void DoChangeDrinkColor()
        {
            ChangeDrinkType.ChangeDrink(this.gameObject);
        }

        public abstract void Serve();

        public void Update()
        {
            // change drink to Coke (RED) with 1
            //2 water
            //3 coffee
            //click for serve (destroy)
            //r for restock
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkCoke>();
            }
            // change color to blue for water
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkWater>();
            }
            // change color to black for coffee
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                ChangeDrinkType = ScriptableObject.CreateInstance<ChangeDrinkCoffee>();
            }
            // allows to reload scene reload assests
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (GameObject.FindGameObjectsWithTag("Drink").Length <= 0)
            {
                restartText.text = "All Drinks have been served. Press to R to restock!";
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}
