using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectShot : Weapon
{

    public GameObject projectilePrefab;
    public float shotSpeed = 20f;
    
    public override void Attack()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shotDirection = (mousePos - (Vector2)transform.position).normalized;
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = shotDirection * shotSpeed;
        projectile.GetComponent<Projectile>().damage = this.damage;
    }
}
