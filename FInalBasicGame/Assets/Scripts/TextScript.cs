using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI Counter;
    public TextMeshProUGUI NumberText;

    public GameObject Enemy;

    public CollisionDetector collisionScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {     
        if (collisionScript.hitCounter >= 5)
        {
            Counter.text = "Nice Job! You Won!" + "Press R to Restart";
            Destroy(Enemy);
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        if (collisionScript.hitCounter < 5)
        {
            Counter.text = "Hit the enemy(red cube) 5 times to win!" + "Press R to Restart";
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
