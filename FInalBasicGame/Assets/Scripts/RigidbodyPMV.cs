using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPMV : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rigibody;

    // Start is called before the first frame update
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical")) * moveSpeed;
        Debug.Log("Currently detecting" + rigibody);
    }
}
