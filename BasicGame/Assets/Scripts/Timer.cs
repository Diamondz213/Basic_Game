using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public CollisionDetector collisionScript;

    public float countdownTimer = 10f;
    public float countingDown = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countingDown -= 1 * Time.deltaTime;
        TimerText.text = "Time Left: " + countdownTimer;

        if (collisionScript.hitCounter >= 1)
        {
            countingDown = 999;
        }

        if (countingDown <= 0)
        {
            countdownTimer -= 1;
            countingDown = 1f;

            if(countdownTimer <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
