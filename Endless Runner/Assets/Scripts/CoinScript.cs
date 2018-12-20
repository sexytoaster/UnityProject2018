using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

    private PlayerMotor playerMotor;
    public GameObject player;
    public Text coinText;
    public static int Coins;

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
        coinText.text = "Coins:   " + Coins;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Coins++;
            Destroy(gameObject);
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
