using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights1 : MonoBehaviour
{
    public Light Light1;

    private void Start()
    {
        Light1 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light1.intensity = 1;

            //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box
        
    }
}
