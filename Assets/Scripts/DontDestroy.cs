using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    int l = 0;
    private void Update()
    {
        DontDestroyOnLoad(gameObject);
        if (l == 2)
        {
            Destroy(gameObject);
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        l += 1;
    }
}
