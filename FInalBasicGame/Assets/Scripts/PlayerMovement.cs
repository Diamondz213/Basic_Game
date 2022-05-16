using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed;
    public AudioSource WalkSound;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Rigidbody RB;
    public float jumpAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        WalkSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
            WalkSound.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
            WalkSound.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
            WalkSound.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
            WalkSound.Play();
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }

    }

}
