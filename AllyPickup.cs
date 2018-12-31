using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyPickup : MonoBehaviour,I_Play {
    private GameObject player;
    private PlayerController playcont;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        player = GameObject.Find("Player");
        playcont = player.GetComponent("PlayerController") as PlayerController;
	}
	
	// Update is called once per frame

  public  void endGame() {
        gameObject.SetActive(true);
       
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            playcont.allies = (playcont.allies + 1);
        }
    }
}
