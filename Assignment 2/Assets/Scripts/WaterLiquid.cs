/*
 * Nmae: George Tang
 * Project: Assignment 2
 * File: WaterLiquid.cs
 * Description: Spawns a sphere object for water liquid
 */
using UnityEngine;
using System.Collections;

public class WaterLiquid : ServeDrink
{

    public override void Serve()
    {
        Instantiate(Resources.Load("WaterLiquid"), gameObject.transform.position, gameObject.transform.rotation);
    }
}
