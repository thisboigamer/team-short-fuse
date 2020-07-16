using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrippingHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter trigger");

        //check if object is tagged as a Player
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Timer>().LoseTime();

            FindObjectOfType<Damage>().DamageUI();

            Destroy(gameObject);

            Debug.Log("Slipped on a Banana");

        }
    }
    //destroy the player
}
