using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

    

    public static int scores1 = 5;
    public static int scores2 = 4;
    public static int scores3 = 3;
    public static int scores4 = 2;
    public static int scores5 = 1;

    public Text scoresA;
    public Text scoresB;
    public Text scoresC;
    public Text scoresD;
    public Text scoresE;
    public static int[] Scores = new int[5];


    public void Start()
    {
        Scores[0] = scores1;
        Scores[1] = scores2;
        Scores[2] = scores3;
        Scores[3] = scores4;
        Scores[4] = scores5;
    }

    public void Update()
    {
        scoresA.text = Scores[0].ToString();
        scoresB.text = Scores[1].ToString();
        scoresC.text = Scores[2].ToString();
        scoresD.text = Scores[3].ToString();
        scoresE.text = Scores[4].ToString();
    }

    public void TryAddHighScore(int newScore)
    {
        int temp = 0;

        for (int i = 0; i < Scores.Length; i++)
        {
            if (newScore > Scores[i])
            {
                temp = Scores[i];
                Scores[i] = newScore;
                newScore = temp;
            }
            else
            {

            }
        }
    }
}
