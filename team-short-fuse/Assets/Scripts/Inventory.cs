using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool fuse1ininventory = false;
    public bool fuse2ininventory = false;
    public bool fuse3ininventory = false;
    public bool fuse4ininventory = false;
    public bool fuse5ininventory = false;
    public bool fuse6ininventory = false;
    public GameObject FuseGetUI;
    //Creates the inventory system

    private void RemoveFuseUI()
    {
        FuseGetUI.SetActive(false);
    }

    public void FuseUI()
    {
        FuseGetUI.SetActive(true);

        Invoke("RemoveFuseUI", 1);
    }






}
