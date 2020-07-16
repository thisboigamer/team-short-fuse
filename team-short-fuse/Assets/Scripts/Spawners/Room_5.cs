using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_5 : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float xPos, zPos;
    [SerializeField] private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount >= 0)
        {
            //randomize the x-position
            xPos = Random.Range(-12.4f, -20.7f);
            zPos = Random.Range(49.9f, 58.7f);
            //create a new enemy
            Instantiate(enemy, new Vector3(xPos, 1.667f, zPos), Quaternion.identity);
            //wait for 1 second before running again
            yield return new WaitForSeconds(10);
            //add 1 to enemyCount
            enemyCount += 1;
        }


    }
}