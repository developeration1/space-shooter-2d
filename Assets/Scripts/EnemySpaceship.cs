using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceship : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.down * speed * Time.deltaTime;
    }
}
