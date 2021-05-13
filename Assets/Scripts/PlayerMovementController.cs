using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 2;
    float _jumpForce = 400;
    Rigidbody2D _rb;


    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * (Time.deltaTime * _moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(Vector2.up * _jumpForce);
        }
    }
}