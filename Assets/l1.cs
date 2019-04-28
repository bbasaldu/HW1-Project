using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l1 : MonoBehaviour
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
        lightGameObject.transform.position = new Vector3(10, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
