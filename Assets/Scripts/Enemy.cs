using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed = 2f;
    
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
}
