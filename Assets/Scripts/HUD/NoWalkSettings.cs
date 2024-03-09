using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoWalkSettings : MonoBehaviour
{
    public static int zero = 1;
    public void NoWalke()
    {
        zero = 0;
    }
    public void Walk()
    {
        zero = 1;
    }
}
