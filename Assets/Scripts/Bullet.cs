using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    GameObject parent;
    PlayerStats playerStats;



    public int DamageLevel = 1;

    private void Start()
    {

            parent = GameObject.Find("Local");
            playerStats = parent.GetComponent<PlayerStats>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        
        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage(playerStats.Damage);
        }
        Destroy(gameObject);
        
    }
}
