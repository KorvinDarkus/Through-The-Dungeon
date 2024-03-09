using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    bool IsFoolScreen;
    public void FullScreenToggle()
    {
        IsFoolScreen = !IsFoolScreen;
        Screen.fullScreen = IsFoolScreen;
    }
}
