/*
* Nmae: George Tang
* Project: Assignment 2
* File: Beverages.cs
* Description: Created an abstract base amd child classes must implement their own 
*              specifc Serve behaviors
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    
public abstract class Beverages : MonoBehaviour
{
       
    public ServeDrink serveDrinkBehavior;
        
    public virtual void DoServe()
    {
        serveDrinkBehavior.Serve();
    }
        void Update()
        { 
            if (Input.GetKeyDown(KeyCode.Q))
            {
                    DoServe();
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                serveDrinkBehavior = gameObject.AddComponent<SodaLiquid>();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GetComponent<MeshRenderer>().material.color = Color.blue ;
                serveDrinkBehavior = gameObject.AddComponent<WaterLiquid>();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                GetComponent<MeshRenderer>().material.color = Color.black;
                serveDrinkBehavior = gameObject.AddComponent<CoffeeLiquid>();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            

        }
}
