using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class CharacterAnimation : MonoBehaviour
{
    Animator _animator;
    IMove _mover;
    SpriteRenderer _spriteRenderer;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _mover = GetComponent<IMove>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float speed = _mover.Speed;
        _animator.SetFloat("Speed", Mathf.Abs(speed));

        if (speed != 0)
            _spriteRenderer.flipX = speed > 0;
    }
}