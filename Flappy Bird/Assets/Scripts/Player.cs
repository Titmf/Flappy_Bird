using System;

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;

    private SpriteRenderer _spriteRenderer;
    private int _spriteIndex;
    private Vector3 _direction;
    private const float Gravity = -9.8f;
    private const float Strength = 5f;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f );
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _direction = Vector3.up * Strength;
        }

        _direction.y += Gravity * Time.deltaTime;
        transform.position += _direction * Time.deltaTime;
    }
    private void AnimateSprite()
    {
        _spriteIndex++;

        if (_spriteIndex >= _sprites.Length)
        {
            _spriteIndex = 0;
        }

        _spriteRenderer.sprite = _sprites[_spriteIndex];
    }
}