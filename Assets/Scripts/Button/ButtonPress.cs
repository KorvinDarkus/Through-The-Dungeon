using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    GameObject[] button;
    GameObject closest;
    public static GameObject nearestbutton;
    public static string nearest;

    void Start()
    {
        button = GameObject.FindGameObjectsWithTag("Button");
    }

    GameObject FindClosestButton()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in button)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Update()
    {
        nearest = FindClosestButton().name;
        nearestbutton = GameObject.Find("" + nearest);
        Debug.Log(nearest);
    }
   // private void OnMouseDown()
   // {
   //     
   //     Button.PressTheButton();
   // }
}
