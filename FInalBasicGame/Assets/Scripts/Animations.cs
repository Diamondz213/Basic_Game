using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator playerController; //Character Animation Controller
    public bool IsRunning;

    // Start is called before the first frame update
    void Start()
    {
        IsRunning = playerController.GetBool("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRunning == true)
        {
            playerController.Play("Running");
        }
        else
            playerController.Play("Idle");
    }
}
