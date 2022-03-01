using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI Counter;
    public TextMeshProUGUI NumberText;

    public GameObject Enemy;

    public bool gameWon = false;

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
            Counter.text = "Nice Job! You Won!";
            Destroy(Enemy);
            gameWon = true;
        }
        else
        if (collisionScript.hitCounter < 5)
        {
            Counter.text = "Hit the enemy(red cube) 5 times to win!";
        }
    }
}
