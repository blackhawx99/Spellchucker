using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMove : MonoBehaviour
{

    private GameObject player;
    private Transform playerLocation;
    private float EneSpeed = 2f;
    private float InRange = 0.1f;
    private float healthValue;
    private GameObject levelManager;
    private LevelManager managerScript = null;


    private void Start()
    {
        player = GameObject.Find("Player");
        playerLocation = player.transform;
        healthValue = 100;
        levelManager = GameObject.Find("GameLevelManager");
    }
    void Update()
    {


        transform.LookAt(playerLocation);

        if (Vector3.Distance(transform.position, playerLocation.position) >= InRange)
        {

            transform.position += transform.forward * EneSpeed * Time.deltaTime;


        }
        if (healthValue <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        managerScript = levelManager.GetComponent("LevelManager") as LevelManager;
        managerScript.score = (managerScript.score + 10);
        Destroy(gameObject);

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "DeathSphere")
        {
            print("Hit");
            healthValue = (healthValue - 50);
        }
    }
}