using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Make a game object
        GameObject lightGameObject = new GameObject("The Light");

        // Add the light component
        Light lightComp = lightGameObject.AddComponent<Light>();

        // Set color and position
        lightComp.color = Color.blue;

        // Set the position (or any transform property)
       

        lightComp.type = LightType.Point;
        lightComp.range = 10;
        //int i = -10;
        lightGameObject.transform.position = new Vector3(0, 3, -10);
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, 0.01f);
    }
}
