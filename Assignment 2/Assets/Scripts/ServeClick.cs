/* 
 * George Tang 
 * ServeClick.cs 
 * Assignment 2
 * Assignment Description:
 * attach to main camera
 */
using UnityEngine;
using System.Collections;

using StrategyPatternWithScriptableObjects;

public class ServeClick : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                Serve objectHit = hitInfo.collider.GetComponent<Serve>();

                if(objectHit != null)
                {
                    objectHit.Serve();
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                Beverage objectHit = hitInfo.collider.GetComponent<Beverage>();

                if (objectHit != null)
                {
                    objectHit.DoChangeDrinkColor();
                }
            }
        }
    }
}
