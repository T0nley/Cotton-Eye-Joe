using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    // Start is called before the first frame update
    public int HealthAmmount = 30;
    private void OnCollison(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.AddHealth(HealthAmmount);
            Destroy(gameObject);
            D
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
