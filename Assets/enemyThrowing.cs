using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyThrowing : MonoBehaviour
{
    public int damage;

    private Rigidbody rb;

    private bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (targetHit)
            return;
        else
            targetHit = true;

        if (collision.gameObject.tag == "player")
        {
            Destroy(collision.gameObject);
        }

    }
}

