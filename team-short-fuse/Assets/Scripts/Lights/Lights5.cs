using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights5 : MonoBehaviour
{
    public Light Light5;

    private void Start()
    {
        Light5 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light5.intensity = 1;

        //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box

    }
}
