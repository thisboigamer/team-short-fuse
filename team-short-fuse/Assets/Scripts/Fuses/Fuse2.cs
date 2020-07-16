using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    //checks if something has collided with the Fuse
    {
        Debug.Log("enter trigger");

        if (other.tag == "Player")
        //Checks if the object is a player
        {
            Debug.Log("Player Detected");

            if (FindObjectOfType<FuseBox>().fuse1collected == true)
            {
                FindObjectOfType<Inventory>().fuse2ininventory = true;

                Destroy(gameObject);

                Debug.Log("Fuse two Get");
                //Removes the fuse from the map and puts it in the player's inventory

                FindObjectOfType<Inventory>().FuseUI();

                //Gives the player an on screen prompt telling them they found the fuse
            }
        }
    }
}
