using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    Animator anime;
    CharacterController controller;

    float speed = 20f;

    private Vector3 velocity;
    private bool isGrounded;
    private float groundCheckDistance = 0.2f;
    public LayerMask groundMask;
    private float gravity = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        if(isGrounded && velocity.y<0)
            velocity.y = -2f;

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction = transform.transform.TransformDirection(direction);
        controller.Move(direction * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            anime.SetBool("IsWalking", true);
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            anime.SetBool("IsWalking", false);
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anime.SetBool("IsRunning", true);
            speed = 35f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            anime.SetBool("IsRunning", false);
            speed = 20f;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
            anime.SetTrigger("Jump");
        
        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        Vector3 newrotation = transform.localEulerAngles;
        newrotation.y += Input.GetAxis("Mouse X");
        transform.localEulerAngles = newrotation;
    }

}
