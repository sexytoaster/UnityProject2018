using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighscoreScene : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button highscore = gameObject.GetComponent<Button>();
        highscore.onClick.AddListener(delegate () { ChangeHighscore("HighscoreMenu"); });
    }

    // Update is called once per frame
    public void ChangeHighscore(string level)
    {
        SceneManager.LoadScene("HighscoreMenu");
    }
}
