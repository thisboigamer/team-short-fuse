using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : MonoBehaviour
{

   public bool fuse1collected = false;
   public bool fuse2collected = false;
   public bool fuse3collected = false;
   public bool fuse4collected = false;
   public bool fuse5collected = false;
   public bool fuse6collected = false;
   public GameObject FuseInsertUI;
   public GameObject GetPoptartUI;

    private void RemoveUI()
    {
    FuseInsertUI.SetActive(false);
    }

    private void RemoveUIPoptart()
    {
        FuseInsertUI.SetActive(false);
    }


    //Sets the Default values for the fuses being aquired

    private void OnTriggerEnter(Collider other)
    //Activates when an object enters the fuse box collider
    {
        Debug.Log("enter trigger");

        if (other.tag == "Player")
        //Checks if the object is the player
        {

            Debug.Log("Human Detected");

            if (FindObjectOfType<Inventory>().fuse1ininventory == true)
            //Checks if the player has the fuse
            {

                Debug.Log("You have the first fuse");

                fuse1collected = true;

                FindObjectOfType<Inventory>().fuse1ininventory = false;

                Debug.Log("Fuse one Inserted");

                //Removes the fuse from the user's inventory and adds it to the fuse box

                FuseInsertUI.SetActive(true);

               Invoke("RemoveUI", 2);
                //Gives the User a prompt telling them they put a fuse in the box

                GameObject findLightset1 = GameObject.FindGameObjectWithTag("Lightset1"); //find an object with the lightset1 tag
                Lights1 getscript = findLightset1.GetComponent<Lights1>(); //reference the objects script which is called Lights1
                getscript.LightTest(); // calls the LightTest function

            }

           if (FindObjectOfType<Inventory>().fuse2ininventory == true)
            //Checks if the player has the second fuse
            {

                Debug.Log("You have the second fuse");

                fuse2collected = true;

                FindObjectOfType<Inventory>().fuse2ininventory = false;

                Debug.Log("Fuse 2 Inserted");

                //Removes  the second fuse from the user's inventory and adds it to the fuse box

                FuseInsertUI.SetActive(true);

                Invoke("RemoveUI", 2);
                //Gives the User a prompt telling them they put a fuse in the box

                GameObject findLightset2 = GameObject.FindGameObjectWithTag("Lightset2"); //find an object with the lightset1 tag
                Lights2 getscript = findLightset2.GetComponent<Lights2>(); //reference the objects script which is called Lights1
                getscript.LightTest(); // calls the LightTest function

            }

            if (FindObjectOfType<Inventory>().fuse3ininventory == true)
            //Checks if the player has the third fuse
            {

                Debug.Log("You have the third Fuse");

                fuse3collected = true;

                FindObjectOfType<Inventory>().fuse3ininventory = false;

                Debug.Log("Fuse 3 Inserted");

                //Removes the third fuse from the user's inventory and adds it to the fuse box

                FuseInsertUI.SetActive(true);

                Invoke("RemoveUI", 2);
                //Gives the User a prompt telling them they put a fuse in the box

                GameObject findLightset3 = GameObject.FindGameObjectWithTag("Lightset3"); //find an object with the lightset1 tag
                Lights3 getscript = findLightset3.GetComponent<Lights3>(); //reference the objects script which is called Lights1
                getscript.LightTest(); // calls the LightTest function



            }

            if (FindObjectOfType<Inventory>().fuse4ininventory == true)
            //Checks if the player has the fourth fuse
            {

                Debug.Log("You have the fourth fuse");

                fuse4collected = true;

                FindObjectOfType<Inventory>().fuse4ininventory = false;

                Debug.Log("Fuse 4 Inserted");

                //Removes the fourth fuse from the user's inventory and adds it to the fuse box

                FuseInsertUI.SetActive(true);

                Invoke("RemoveUI", 2);
                //Gives the User a prompt telling them they put a fuse in the box

                GameObject findLightset4 = GameObject.FindGameObjectWithTag("Lightset4"); //find an object with the lightset1 tag
                Lights4 getscript = findLightset4.GetComponent<Lights4>(); //reference the objects script which is called Lights1
                getscript.LightTest(); // calls the LightTest function

            }

            if (FindObjectOfType<Inventory>().fuse5ininventory == true)
            //Checks if the player has the fifth fuse
            {

                Debug.Log("You have the fifth fuse");

                fuse5collected = true;

                FindObjectOfType<Inventory>().fuse5ininventory = false;

                Debug.Log("Fuse 5 Inserted");

                //Removes the fifth fuse from the user's inventory and adds it to the fuse box

                FuseInsertUI.SetActive(true);

                Invoke("RemoveUI", 2);
                //Gives the User a prompt telling them they put a fuse in the box

                GameObject findLightset5 = GameObject.FindGameObjectWithTag("Lightset5"); //find an object with the lightset1 tag
                Lights5 getscript = findLightset5.GetComponent<Lights5>(); //reference the objects script which is called Lights1
                getscript.LightTest(); // calls the LightTest function


            }

            if (FindObjectOfType<Inventory>().fuse6ininventory == true)
            //Checks if the player has the second fuse
            {

                Debug.Log("You have the sixth fuse");

                fuse6collected = true;

                FindObjectOfType<Inventory>().fuse6ininventory = false;

                Debug.Log("Fuse 6 Inserted");

                //Removes the sixth fuse from the user's inventory and adds it to the fuse box

                GetPoptartUI.SetActive(true);

                Invoke("RemoveUIPoptart", 2);
                //Gives the User a prompt telling them they put a fuse in the box and to go get their poptart


            }
        }
    }
}
