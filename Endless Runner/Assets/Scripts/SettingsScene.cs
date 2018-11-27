using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsScene : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button setting = gameObject.GetComponent<Button>();
        setting.onClick.AddListener(delegate () { ChangeSettings("SettingsMenu"); });
    }

    // Update is called once per frame
    public void ChangeSettings(string level)
    {
        SceneManager.LoadScene("SettingsMenu");
    }
}
