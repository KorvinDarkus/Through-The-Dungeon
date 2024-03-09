using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlevel : MonoBehaviour
{
    public GameObject CantWin;
    public GameObject hud;
    public GameObject other;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (CoinCounter.coins == 3)
            {
                other.SetActive(true);
                hud.SetActive(false);
            }
            else
            {
                CantWin.SetActive(true);
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        CantWin.SetActive(false);
    }
}
