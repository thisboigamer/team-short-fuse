using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    private float restartDelay = 3.5f;
    public GameObject winLevelUI;
    public GameObject loseLevelUI;
    public GameObject InventoryUI;
    public GameObject FuseboxUI;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoseGame()
    {
        if (GameHasEnded == false) //Checks if the game has ended variable is false
        {
            GameHasEnded = true; //sets GameHasEnded to true
            loseLevelUI.SetActive(true);

            Debug.Log("GAME OVER");
            //restart game - function defined below
            Invoke("Restart", restartDelay);
        }
    }


    public void WinGame()
    {
        //Show Win UI to player
        winLevelUI.SetActive(true);
        
        Debug.Log("You Win!");

        Invoke("Restart", restartDelay);
    }

   
}
