using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour
{
    public static float nowcoins;
    public static float collectedcoins;
    public UnityEngine.UI.Text coincounter;
    public static float coins = 0;
    public static float countcoin1 = 0;
    public static float countcoin2 = 0;
    public static float countcoin3 = 0;
    public static float countcoin4 = 0;
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
            nowcoins = (SceneManager.GetActiveScene().buildIndex-1) * 3 + coins;
            coincounter.text = "" + nowcoins;
        }
        else
        {
            coincounter.text = "" + coins;
        }
    }
}
