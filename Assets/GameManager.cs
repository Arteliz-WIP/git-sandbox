﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinText;
    int coins;

    public Text Deathcount;
    int Deaths;

    public void AddCoin()
    {
        coins++;
        Debug.Log("Coins: " + coins);

        //Cambiar texto en pantalla
        coinText.text = "Coins: " + coins;
    }

    public void AddDeaths()
    {
        Deaths++;
        Debug.Log("Deaths: " + Deaths);

        Deathcount.text = "Deaths: " + Deaths;
    }

    public void Gameover()
    {
        Debug.Log("YOU DIED");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
