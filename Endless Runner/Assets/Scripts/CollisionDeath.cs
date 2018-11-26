using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDeath : MonoBehaviour {
    
	public void Death() {
        Debug.Log("Death?");
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("DeathScreen");
        }
	
}
