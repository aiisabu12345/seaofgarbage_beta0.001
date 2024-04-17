using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5;
    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody>(); // Initialize the Rigidbody
        movement = Vector3.zero; // Initialize movement
    }

    private void FixedUpdate()
    {
        if (player != null) // Check if player exists
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            rb.rotation = Quaternion.Euler(0, angle, 0); // Set rotation using Quaternion.Euler
            direction.Normalize();
            movement = direction;
            moveCharacter(movement);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);
    }
}