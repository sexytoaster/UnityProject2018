using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagnetToggle : MonoBehaviour {

    public PlayerMotor playermotor;
	// Use this for initialization
	void Start () {
        playermotor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ToggleAnalog()
    {
        StartCoroutine(Toggle());

    }

    IEnumerator Toggle()
    {
        playermotor.magnetic = !playermotor.magnetic;
        Debug.Log("OOF");
        yield return new WaitForSeconds(5.0f);
        playermotor.magnetic = !playermotor.magnetic;
    }
}
