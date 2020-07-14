using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    //checks if something has collided with the Fuse
    {
        Debug.Log("enter trigger");

        if (other.tag == "Player")
        //Checks if the object is a player
        {
            Debug.Log("Player Detected");

            if (FindObjectOfType<FuseBox>().fuse2collected == true)
            {
                FindObjectOfType<Inventory>().fuse3ininventory = true;

                Destroy(gameObject);

                Debug.Log("Fuse three get");
            }
        }
    }
}
