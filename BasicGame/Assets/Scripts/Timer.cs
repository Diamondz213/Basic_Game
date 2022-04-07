using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float countdownTimer = 10f;
    public float countingDown = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countingDown -= 1 * Time.deltaTime;

        if (countingDown <= 0)
        {
            countdownTimer -= 1;
            countingDown = 60f;
            print("The countdown is " + countdownTimer);

            if(countdownTimer <= 0)
            {
                countdownTimer = 10;
            }
        }
    }
}
