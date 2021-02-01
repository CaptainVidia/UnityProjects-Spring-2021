using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Beverage> classList = new List<Beverage>();
    public List<Drinking> interfaceList = new List<Drinking>();

    // Start is called before the first frame update
    void Start()
    {
        classList.Add(new Soda("Pepsi"));
        classList.Add(new Soda("Coke"));
        classList.Add(new Water("Sprakle"));
        classList.Add(new Water("Distilled"));
        classList.Add(new NonWater("Coffee"));

        interfaceList.Add(new Soda("Pepsi"));
        interfaceList.Add(new Soda("Coke"));
        interfaceList.Add(new Water("Sprakle"));
        interfaceList.Add(new Water("Distilled"));
        interfaceList.Add(new NonWater("Coffee"));


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Beverage t in classList)
            {
                t.Pour();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Drinking t in interfaceList)
            {
                t.Drink();
            }
        }
    }
}
