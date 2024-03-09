using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    public GameObject other;
    float starty;
    float startx;
    bool movetoend = true;
    bool abletopress = false;
    public float xmove;
    public float ymove;
    public float speed;
    bool pressed = false;
    private void Start()
    {
        starty = other.transform.position.y;
        startx = other.transform.position.x;
    }
    private void OnMouseDown()//Нажатие кнопки
    {
        if (abletopress == true)
        {
            pressed = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)//Возможность нажать на кнопку только когда игрок рядом с ней
    {
        abletopress = true;
    }

    private void OnTriggerExit2D(Collider2D collision)//Возможность нажать на кнопку только когда игрок рядом с ней
    {
        abletopress = false;
    }
    void FixedUpdate()
    {

        if (pressed && !movetoend)
        {
            Moveaway();
            if (new Vector2(other.transform.position.x, other.transform.position.y) == new Vector2(startx,starty))
            {
                pressed = false;
                movetoend = !movetoend;
            }
        }

        if (pressed && movetoend)
        {
            Move();
            if(new Vector2 (other.transform.position.x,other.transform.position.y) == new Vector2(xmove+startx,ymove+starty))
            {
                pressed = false;
                movetoend = !movetoend;
            }
        }
    }

     void Move()
    {
        other.transform.position = Vector2.MoveTowards(other.transform.position, new Vector2(other.transform.position.x,other.transform.position.y) + new Vector2(xmove, ymove), speed);//Движение объекта в конечную точку
    }
    void Moveaway()//Движение объекта в начальную точку
    {
        other.transform.position = Vector2.MoveTowards(other.transform.position, new Vector2(startx, starty), speed);
    }
    //public static void PressTheButton()
   // {
   //     if (abletopress == true)
  //      {
   //         pressed = true;
  //      }
  //  }
}
