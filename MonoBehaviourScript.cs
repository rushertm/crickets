using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       print("Hello, world!");
       Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        print("crickets");
         float quotient = (float)9385 / 2;
        print("Частное: " + quotient);
    }
}
