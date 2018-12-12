using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public int Coins = 0;

    public int score;
    public int score1;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        score = score + 1;
        score1 = score + (Coins * 10);
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins : " + Coins);
        GUI.Label(new Rect(10, 30, 100, 20), "Score : " + score1);
    }
}
