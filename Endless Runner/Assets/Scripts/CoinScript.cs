using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    private PlayerMotor playerMotor;
    public GameObject player;

    // Use this for initialization
    void Start () {
        playerMotor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        float coinSpeed = playerMotor.speed + 10;
		if(playerMotor.magnetic == true)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 5)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * coinSpeed);
            }
        }
	}

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin??");
        if (other.name == "Player")
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<Score>().Coins++;
            Destroy(gameObject);
            Debug.Log("Coin??");
        }
        else
        {
            Destroy(gameObject);
        }
    }
    /*
    if(Vector3.Distance(transform.position, player.position) < dist)
        {
              transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime* coinSpeed);
        }*/
}
