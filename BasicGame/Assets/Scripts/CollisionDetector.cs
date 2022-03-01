using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetector : MonoBehaviour
{
    public float hitCounter;
    public TextMeshProUGUI NumberText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           hitCounter += 1;
           print("I've been hit " + hitCounter + " times.");
            NumberText.text = hitCounter.ToString();
            NumberText.text = ("Hit Count: " + hitCounter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
