using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour

{
    public PlayerProgress playerProgress;

    public float value = 100;
    


    // Update is called once per frame
    private void Start()
    {
        playerProgress = FindObjectOfType<PlayerProgress>();  
    }

    private void Update()
    {
        
    }
    public void DealDamage(float damage)
    {
        playerProgress.AddExperience(damage);
        value -= damage;
        
        if (value <= 0)
        {
            Destroy(gameObject);
           
        }     
    }






}

