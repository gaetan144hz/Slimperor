using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_P_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        speed = 1.5f;
    }

    void Update()
    {
        rb.velocity = speed * movement;
    }
}
