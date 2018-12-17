using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        playermotor.magnetic = !playermotor.magnetic;
        Debug.Log("OOF");
    }
}
