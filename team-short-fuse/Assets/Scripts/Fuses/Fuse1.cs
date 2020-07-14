using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    //checks if something has collided with the Fuse
    {
        Debug.Log("enter trigger");

        if (other.tag == "Player")
        //Checks if the object is a player
        {
            Debug.Log("Player Detected");

            FindObjectOfType<Inventory>().fuse1ininventory = true;

            Destroy(gameObject);

            Debug.Log("Fuse one Get");
        }
    }
}
