using System;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    Animator _animator;
    IMove _mover;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _mover = GetComponent<IMove>();
    }

    void Update()
    {
        _animator.SetFloat("Speed", _mover.Speed);
    }
}