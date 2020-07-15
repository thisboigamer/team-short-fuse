using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    private void OnTriggerEnter(Collider colliderInfo)
    {
        //limit to only when Player enters the field
        if (colliderInfo.tag == "Player")
        //Collider target = Collider.GetComponent(colliderInfo.tag);
        {
            if (FindObjectOfType<FuseBox>().fuse1collected == true)
            {
                if (FindObjectOfType<FuseBox>().fuse2collected == true)
                {
                    if (FindObjectOfType<FuseBox>().fuse3collected == true)
                    {
                        if (FindObjectOfType<FuseBox>().fuse4collected == true)
                        {
                            if (FindObjectOfType<FuseBox>().fuse5collected == true)
                            {
                                if (FindObjectOfType<FuseBox>().fuse6collected == true)
                                //Checks to make sure that the player has put all 6 fuses in the fuse box
                                {
                                    FindObjectOfType<GameManager>().WinGame();
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
