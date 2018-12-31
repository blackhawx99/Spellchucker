using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public float score;
    private float enemiesLeft;
    private I_Play iplay;
    private GameObject iplayholder;

	// Use this for initialization
	void Start () {
        iplayholder = GameObject.Find("Ally");
        iplay = iplayholder.GetComponent("I_Play") as I_Play;
       
        score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesLeft = enemies.Length;
        if (enemiesLeft <= 0)
        {
            iplay.endGame();
        }

    }
}
