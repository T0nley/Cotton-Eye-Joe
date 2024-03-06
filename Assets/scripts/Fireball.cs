﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;

    // Start is called before the first frame pdate
    private void FixedUpdate()
    {

        MoveFixedUpdate();
    }


    // Update is called once per frame
    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyFireball();
        DamageEnemy(collision);
    }

    private void DestroyFireball()
    {
        Destroy(gameObject);

    }

    private void Start()
    {
        Invoke("DestroyFireball", lifetime);
    }



    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }


}

        
