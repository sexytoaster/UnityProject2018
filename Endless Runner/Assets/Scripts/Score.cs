using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int Coinsui;
    public int score;
    public int score1;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        score = 0;
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Coinsui = CoinScript.Coins;
        score = score + 1;
        score1 = score + (Coinsui * 10);
        scoreText.text = "Score:   " + score1;
    }
}
