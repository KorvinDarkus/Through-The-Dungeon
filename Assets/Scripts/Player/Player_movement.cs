using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    private Animator animator;
    public float speed;
    private float vector;
    public Rigidbody2D rb;
    private bool isfacingright = true;//Персонаж смотрит вправо
    public bool isgrounded;
    public ControlType controltype;
    public Joystick joystic;
    public enum ControlType { PC, Android }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (controltype == ControlType.PC)
        {
            vector = Input.GetAxisRaw("Horizontal");
        }
        else if (controltype == ControlType.Android)
        {
            vector = joystic.Horizontal;
        }

        if (vector > 1)
        {
            vector = 1;
        }
        else if (vector < -1)
        {
            vector = -1;
        }
        else
        {
            rb.velocity = new Vector2(vector * speed * NoWalkSettings.zero, rb.velocity.y);
        }

        if (vector == 0)
        {
            animator.SetBool("IsRunning",false);
        }
        else
        {
            animator.SetBool("IsRunning", true);
        }

        if (vector > 0 && !isfacingright)
        {
            Flip();
        }
        else if (vector < 0 && isfacingright)
        {
            Flip();
        }

    }


    private void Flip() //Поворот
    {
        isfacingright = !isfacingright;
        Vector2 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }

}
