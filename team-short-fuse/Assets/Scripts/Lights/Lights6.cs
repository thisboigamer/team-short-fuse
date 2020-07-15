using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights6 : MonoBehaviour
{
    public Light Light6;

    private void Start()
    {
        Light6 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light6.intensity = 1;

        //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box

    }
}
