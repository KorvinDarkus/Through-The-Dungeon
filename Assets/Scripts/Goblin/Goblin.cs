using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goblin : MonoBehaviour
{
    private float startx;
    public float speed;
    public Rigidbody2D rb;
    private bool isfacingright = true;
    public float movex;
    public static float vector = 1;
    public static bool needtoflip = false;

    private void Start()
    {
        startx = gameObject.transform.position.x;
    }
    private void FixedUpdate()
    {

        Vector2 position = gameObject.transform.position;
        if (needtoflip)
        {
            Flip();
            vector *= -1;
            needtoflip = false;
        }
        rb.velocity = new Vector2(vector * speed, rb.velocity.y);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            string levelnumber = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelnumber);
        }
    }
    private void Flip()
    {
        isfacingright = !isfacingright;
        Vector2 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
