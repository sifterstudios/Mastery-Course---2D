using System;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    Animator _animator;
    PlayerMovementController _playerMovementController;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerMovementController = GetComponent<PlayerMovementController>();
    }

    void Update()
    {


        _animator.SetFloat("Speed", _playerMovementController.Speed);
    }
}