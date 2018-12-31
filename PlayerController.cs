using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float manacount;
    public float manaRounded;
    public Collider deathSphere;
    private GameObject aoe;
    public float health;
    public int allies;


    private void Start()
    {
        manacount = 0;
        aoe = GameObject.Find("AoE");
        // deathSphere = aoe.GetComponent<BoxCollider>();
        health = 100;
        allies = 0;

    }


    void Update()
    {
        manacount += (3 * Time.deltaTime);
        manaRounded = (Mathf.RoundToInt(manacount));

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Space) && manaRounded >= 30)
        {
            manaRounded = (manaRounded - 30);
            Instantiate(Resources.Load("AoE"), new Vector3(0, 0, 0), Quaternion.identity);




        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "InZone" || col.gameObject.tag == "Enemy")
        {
            health = (health - 10);


        }

            if (col.gameObject.tag == "Ally")
            {
            allies = (allies + 1);
            }
        }
    }

           

    