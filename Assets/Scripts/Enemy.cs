using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed = 2f;

    public GameObject lootPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (PlayerController.instance.transform.position - transform.position).normalized;
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Health>().TakeDamage(1);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            GetComponent<Health>().TakeDamage(other.gameObject.GetComponent<Projectile>().damage);
            Destroy(other.gameObject);

            if (GetComponent<Health>().currentHealth <= 0)
            {
                Instantiate(lootPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
