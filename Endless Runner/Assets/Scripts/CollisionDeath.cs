using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDeath : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("DeathScreen");
        }
	}
	
	
}
