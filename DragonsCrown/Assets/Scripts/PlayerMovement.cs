using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private Animator myAnimator;
    private Rigidbody2D myRgb;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    [SerializeField]
    private bool attack;
    [SerializeField]
    private Transform[] groundPoints;
    [SerializeField]
    private bool attack2;
    [SerializeField]
    private bool attack3;

    void Awake()
    {
        myAnimator = GetComponent<Animator>();
        myRgb = GetComponent<Rigidbody2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        HandleInput();
   
        if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsTag("AdventurerAttack1Animation"))
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        }

        myAnimator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            myAnimator.SetTrigger("jump");
        }

        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //}
        //else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        HandleAttack();
        ResetValues();
    }

    void HandleAttack()
    {
        if (attack)
        {
            myAnimator.SetTrigger("attack");
            myRgb.velocity = Vector2.zero;
        }
        else if (attack2)
        {
            myAnimator.SetTrigger("attack2");
            myRgb.velocity = Vector2.zero;
        }
        else if (attack3)
        {
            myAnimator.SetTrigger("attack3");
            myRgb.velocity = Vector2.zero;
        }
    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attack = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attack2 = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            attack3 = true;
        }
    }
    private void ResetValues()
    {
        attack = false;
        attack2 = false;
        attack3 = false;
    }
 
}
