using System;
using UnityEngine;

[RequireComponent(typeof(CharacterGrounding))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour, IMove
{
    [SerializeField] float _moveSpeed = 2;
    float _jumpForce = 400;
    Rigidbody2D _rb;
    CharacterGrounding _characterGrounding;
    public float Speed { get; private set; }


    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _characterGrounding = GetComponent<CharacterGrounding>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Speed = Mathf.Abs(horizontal);

        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * (Time.deltaTime * _moveSpeed);

        if (Input.GetButtonDown("Jump") && _characterGrounding.IsGrounded)
        {
            _rb.AddForce(Vector2.up * _jumpForce);
        }
    }
}