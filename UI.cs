using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text manatext;
    public PlayerController playerController;
    public Text score;
    private LevelManager managerScript;
    private GameObject levelManager;
    public Slider healthslider;
    public Text allynumber;

    private void Start()
    {
        levelManager = GameObject.Find("GameLevelManager");
        managerScript = levelManager.GetComponent("LevelManager") as LevelManager;
        
    }
    private void Update()
    {
        manatext.text = playerController.manaRounded.ToString();
        score.text = managerScript.score.ToString();
        healthslider.value = (playerController.health/100);
        allynumber.text = playerController.allies.ToString();

    }


}