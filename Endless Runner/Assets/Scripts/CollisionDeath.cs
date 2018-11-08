using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDeath : MonoBehaviour {

	// Use this for initialization
	void Death() {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("DeathScreen");
        }
	
}
