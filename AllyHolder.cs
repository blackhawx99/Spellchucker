using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyHolder : MonoBehaviour {
    private GameObject a1;
    private GameObject a2;
    private GameObject a3;
    private GameObject a4;
    private GameObject a5;
    private GameObject a6;
    private GameObject a7;
    private GameObject a8;
    private PlayerController playercont;
    private GameObject player;

    // Use this for initialization
    void Start () {
        a1 = GameObject.Find("Ally1");
        a2 = GameObject.Find("Ally2");
        a3 = GameObject.Find("Ally3");
        a4 = GameObject.Find("Ally4");
        a5 = GameObject.Find("Ally5");
        a6 = GameObject.Find("Ally6");
        a7 = GameObject.Find("Ally7");
        a8 = GameObject.Find("Ally8");
        player = GameObject.Find("Player");
        playercont = player.GetComponent("PlayerController") as PlayerController;
        a1.SetActive(false);
        a2.SetActive(false);
        a3.SetActive(false);
        a4.SetActive(false);
        a5.SetActive(false);
        a6.SetActive(false);
        a7.SetActive(false);
        a8.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (playercont.allies >= 1)
        {
            a1.SetActive(true);
        }
        if (playercont.allies >= 2)
        {
            a2.SetActive(true);
        }
        if (playercont.allies >= 3)
        {
            a3.SetActive(true);
        }
        if (playercont.allies >= 4)
        {
            a4.SetActive(true);
        }
        if (playercont.allies >= 5)
        {
            a5.SetActive(true);
        }
        if (playercont.allies >= 6)
        {
            a6.SetActive(true);
        }
        if (playercont.allies >= 7)
        {
            a7.SetActive(true);
        }
        if (playercont.allies >= 8)
        {
            a8.SetActive(true);
        }
        if (playercont.allies == 0)
        {
            a1.SetActive(false);
            a2.SetActive(false);
            a3.SetActive(false);
            a4.SetActive(false);
            a5.SetActive(false);
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
        }

    }
}
