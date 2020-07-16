using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float playtime;
    public Slider TimerUI;

    // Start is called before the first frame update
    void Start()
    {
        TimerUI.maxValue = playtime; //sets the max value of the timer to the value of the time
        playtime = 120f;
        updateUI();

    }

    // Update is called once per frame
    void Update()
    {
        looseTime();
        Timesup();
    }


    private void updateUI()
    {
        //Clamp values between 0 and starting value
        playtime = Mathf.Clamp(playtime, 0, 120); //retaining health between the values of 0 and 120
        TimerUI.value = playtime;
    }

    private void looseTime()
    {
        playtime -= Time.deltaTime;
        updateUI();
    }

    private void Timesup()
    {
        if (playtime == 0)
        {

            FindObjectOfType<GameManager>().LoseGame();

        }
    }

    public void LoseTime()
    {
        //subtract and set health to 
        playtime -= 10;

        updateUI();
    }

}
