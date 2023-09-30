using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Add this script to a TMPro text object.

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI TimerText;  
    private float _remainingTime = 30f;

    void Update()
    {
         Timer();
         SetTimerText();
    }

    private void SetTimerText()
    {
        // Divides current time in seconds by 60 to find the minutes.
        string minutes = Mathf.FloorToInt(_remainingTime / 60f).ToString();

        // Uses modulus to show the remainder of minutes as seconds.
        string seconds = Mathf.FloorToInt(_remainingTime % 60f).ToString();

        // Adds an extra zero if the seconds are in the single digits.
        if(seconds.Length == 1)
        {
            seconds = "0" + seconds;
        }

        // Configures how the timer text will display.
        TimerText.text = minutes + ":" + seconds;
    }

    private void Timer()
    {
        if (_remainingTime > 0)
        {
            // Increments the time.
            _remainingTime -= Time.deltaTime;
        }
        else if (_remainingTime < 0)
        {
            // Avoids the timer counting down into negative numbers.
            _remainingTime = 0;
        }

        // Converts the current time to a string value.
        TimerText.text = _remainingTime.ToString();
        SetTimerText();
    }
}
