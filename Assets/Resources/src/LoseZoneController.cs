﻿using UnityEngine;
using System.Collections;

public class LoseZoneController : MonoBehaviour
{
    PlayerController playerController;
    // Use this for initialization
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("hit registered with " + collider.transform.tag);
        if (collider.transform.tag == "obstacle")
        {
            //transform.GetComponentInParent<SpriteRenderer>().color = Color.red;
            playerController.OnObstacleHit();
        }
    }
}
