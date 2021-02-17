using UnityEngine;
using System.Collections;

public class CoffeeLiquid : ServeDrink
{

    public override void Serve()
    {
        Instantiate(Resources.Load("CoffeeLiquid"), gameObject.transform.position, gameObject.transform.rotation);
    }
}
