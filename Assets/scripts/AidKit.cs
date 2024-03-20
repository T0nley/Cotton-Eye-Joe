﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidKit : MonoBehaviour
{

    public float healAmount = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.AddHealth(healAmount);
            Destroy(gameObject);
        }
    }



}

