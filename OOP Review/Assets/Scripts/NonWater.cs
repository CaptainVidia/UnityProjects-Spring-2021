using UnityEngine;
using System.Collections;

public class NonWater : Beverage, Drinking, Consume
{

    private string name;

    public NonWater(string newName)
    {
        name = newName;
    }

    public void Drink()
    {
        Debug.Log(name + " has been drunk");
    }
    public override void Pour()
    {
        Debug.Log(name + " is the name of the drink");
    }

    public void Pouring()
    {
        Debug.Log(name + " is Pouring from fountain");
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
