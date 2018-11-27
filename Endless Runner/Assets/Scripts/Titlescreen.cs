using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titlescreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Button restart = gameObject.GetComponent<Button>();
        restart.onClick.AddListener(delegate () { Menu("MainMenu"); });
    }

    // Update is called once per frame
    public void Menu(string level)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
