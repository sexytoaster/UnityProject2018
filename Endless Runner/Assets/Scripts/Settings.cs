using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Settings : MonoBehaviour {


    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public Dropdown resolutionsDropdown;
    void Start()
    {
        resolutions = Screen.resolutions;
        Debug.Log(Screen.resolutions.Length);
        resolutionsDropdown.ClearOptions();
        List<string> options = new List<string>();
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            Debug.Log(Screen.resolutions.Length);
            Debug.Log(resolutions.Length);
        }
        resolutionsDropdown.AddOptions(options);

    }
    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
