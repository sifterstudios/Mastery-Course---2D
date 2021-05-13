using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 2;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * _moveSpeed;
    }
}