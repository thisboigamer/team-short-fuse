using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights4 : MonoBehaviour
{
    public Light Light4;

    private void Start()
    {
        Light4 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light4.intensity = 1;

        //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box

    }
}
