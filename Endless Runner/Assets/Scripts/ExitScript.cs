using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Button exit = gameObject.GetComponent<Button>();
        exit.onClick.AddListener(delegate () { ExitGame(); });
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}
