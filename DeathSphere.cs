using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSphere : MonoBehaviour {
    private GameObject player;


  

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

    }







}

