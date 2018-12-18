using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int Coins = 0;

    public int score;
    //public int score1;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        if (GameObject.FindGameObjectsWithTag("Manager").Length > 1)
        {
           Destroy(gameObject);
        }
        
        score = 0;
        scoreText.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        score = score + 1;
        //score1 = score + (Coins * 10);
        scoreText.text = "Score:   " + score;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins : " + Coins);
    }
}
