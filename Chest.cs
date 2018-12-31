using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {
    public int alliesNeeded;
    private GameObject player;
    private PlayerController playcont;
    private LevelManager levelManager;
    private GameObject levman;

    private void Start()
    {
        player = GameObject.Find("Player");
        playcont = player.GetComponent("PlayerController") as PlayerController;
        levman = GameObject.Find("GameLevelManager");
        levelManager = levman.GetComponent("LevelManager") as LevelManager;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && playcont.allies >= alliesNeeded )
        {

            levelManager.score = (levelManager.score + (alliesNeeded * 50));
            playcont.allies = (playcont.allies - alliesNeeded);
            Destroy(gameObject);

        }

       
    }
}
