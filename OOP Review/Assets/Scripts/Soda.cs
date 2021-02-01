using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Personal notes: 
// : -> used to extend class Water with Drink
*/
public class Soda : Beverage, Consume, Drinking
{
    private string name;

    public Soda(string newName)
    {
        name = newName;
    }

    public void Drink()
    {
        Debug.Log(name + "has been drunk");
    }
    public override void Pour()
    {
        Debug.Log(name + " has been poured");
    }

    public void Spilled()
    {
        Debug.Log(name + " has been spilled");
    }

    public void Ordered()
    {
        Debug.Log(name + " has been ordered");
    }

    public void Beverage()
    {
        Debug.Log(name + " has been sold");
    }
}
