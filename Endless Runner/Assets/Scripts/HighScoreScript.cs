using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

    public static int[] Scores;

    public Text scoresA;
    public Text scoresB;
    public Text scoresC;
    public Text scoresD;
    public Text scoresE;

    /// <summary>
    /// HighScore Array must be sorted! With the #0-element has the lowest value.
    /// </summary>


    static public void Start()
    {
        Scores[0] = 5;
        Scores[1] = 4;
        Scores[2] = 3;
        Scores[3] = 2;
        Scores[4] = 1;
    }

    private void Update()
    {
        scoresA.text = Scores[4].ToString();
        scoresB.text = Scores[3].ToString();
        scoresC.text = Scores[2].ToString();
        scoresD.text = Scores[1].ToString();
        scoresE.text = Scores[0].ToString();
    }


    /// <summary>
    /// Try to add the newScore to the HighScore list.
    /// If successed, the new highscore is saved automatically.
    /// </summary>
    /// <param name="newScore"></param>
    /// <returns>'true' if newScore has been placed in the highscore list. Otherwise false.</returns>
    static public void TryAddHighScore(int newScore)
    {
        int found = 0;

        for (int i = 0; i < Scores.Length; i++)
        {
            if (newScore >= Scores[i])
                found++;
        }

        int newValue = newScore,
            tmp;
        while (found > 0)
        {
            int index = (found - 1);
            tmp = Scores[index];
            Scores[index] = newValue;
            newValue = tmp;
            found--;
        }
    }
}
