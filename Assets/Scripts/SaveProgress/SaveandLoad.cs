using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveandLoad : MonoBehaviour
{
    public static int levels = 0;

    public static void Save()
    {
        PlayerPrefs.SetInt("lvl", levels);
        PlayerPrefs.SetFloat("allcoins", CoinCounter.collectedcoins);
        PlayerPrefs.Save();
    }
    void Load()
    {
        PlayerPrefs.GetFloat("lvl");
        PlayerPrefs.GetInt("allcoins");
    }
    private void OnApplicationQuit()
    {
        Save();
    }
    private void Awake()
    {
        Load();
    }

}
