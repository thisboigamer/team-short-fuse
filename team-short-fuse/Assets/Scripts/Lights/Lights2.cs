using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights2 : MonoBehaviour
{
    public Light Light2;

    private void Start()
    {
        Light2 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light2.intensity = 1;

        //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box

    }
}
