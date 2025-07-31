using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float fireRate = 0.5f;
    public float fireTimer = 0.5f;
    public float damage = 1f;

    public virtual void Attack()
    {
        Debug.Log("Parent Class Attack");
    }

    private void Update()
    {
        if (fireTimer <= 0)
        {
            Attack();
            fireTimer = fireRate;
        }
        fireTimer -= Time.deltaTime;
    }
}
