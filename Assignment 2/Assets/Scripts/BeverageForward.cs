using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeverageForward : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < 5)
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
