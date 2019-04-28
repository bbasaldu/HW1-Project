using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l4 : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (i == 0)
        {
            transform.Translate(0f, 0f, 0.01f);
            if(transform.position.z > 0f)
            {
                i = 1;
            }
        }
        else if(i == 1)
        {
            transform.Translate(0f, 0f, -0.01f);
            if(transform.position.z < -3.0f)
            {
                i = 0;
            }
        }







    }
}
