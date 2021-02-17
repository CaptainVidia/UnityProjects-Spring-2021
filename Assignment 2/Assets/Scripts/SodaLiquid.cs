using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SodaLiquid : ServeDrink
{
   public override void Serve()
    {
         Instantiate(Resources.Load("SodaLiquid"), gameObject.transform.position, gameObject.transform.rotation);
    }

}

