using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public GameObject barrier1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goblin")
        {
            Goblin.needtoflip = !Goblin.needtoflip;
            gameObject.SetActive(false);
            barrier1.SetActive(true);
        }
    }
}
