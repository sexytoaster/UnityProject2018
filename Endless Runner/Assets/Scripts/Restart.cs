using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { StartGame("Scene1"); });
	}
	
	// Update is called once per frame
	public void StartGame (string level) {
        SceneManager.LoadScene("Scene1");
	}
}
