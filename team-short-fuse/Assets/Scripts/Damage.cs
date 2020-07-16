using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public GameObject TakeDamageUI;

    private void RemoveDamageUI()
    {
        TakeDamageUI.SetActive(false);
    }

    public void DamageUI()
    {
        TakeDamageUI.SetActive(true);

        Invoke("RemoveDamageUI", 1);
    }
}
