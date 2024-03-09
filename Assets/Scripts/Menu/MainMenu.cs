using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayPressed()
    {
        CoinCounter.countcoin1 = 0;
        CoinCounter.countcoin2 = 0;
        CoinCounter.countcoin3 = 0;
        CoinCounter.coins = 0;
        SceneManager.LoadScene("Tips");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
