using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights3 : MonoBehaviour
{
    public Light Light3;

    private void Start()
    {
        Light3 = GetComponent<Light>();
    }

    // Update is called once per frame
    public void LightTest()
    {

        Light3.intensity = 1;

        //Sets the Lights in the tag "Lightset1" to on if the fuse is in the fuse box

    }

}
