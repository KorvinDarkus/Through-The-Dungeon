using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private float ActiveLevel;
    private float nextlevel;
    private void Update()
    {
        ActiveLevel = SceneManager.GetActiveScene().buildIndex;
        nextlevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void Replay()
    {
        float levelnumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(""+levelnumber);
        CoinCounter.coins = 0;
    }
    public void NextLevel()
    {
        if (ActiveLevel >= SaveandLoad.levels)
        {
            SaveandLoad.levels += 1;
        }
        CoinCounter.coins = 0;
        SceneManager.LoadScene(""+nextlevel);
    }
    public void MenuLoad()
    {
        SceneManager.LoadScene("Menu");
        CoinCounter.collectedcoins = CoinCounter.countcoin1 + CoinCounter.countcoin2 + CoinCounter.countcoin3+ CoinCounter.countcoin4;
        CoinCounter.countcoin1 = 0;
        CoinCounter.countcoin2 = 0;
        CoinCounter.countcoin3 = 0;
        CoinCounter.countcoin4 = 0;
        CoinCounter.coins = 0;
        CoinCounter.nowcoins = 0;
        SaveandLoad.Save();
        CoinCounter.collectedcoins = 0;
    }
}
