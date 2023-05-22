using System;

using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private float _leftEdge;
    private float _deltaScreenEdge = 1f;

    private void Start()
    {
        _leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - _deltaScreenEdge;
    }

    private void Update()
    {
        transform.position  += Vector3.left * (_speed * Time.deltaTime);

        if (transform.position.x < _leftEdge)
        {
            Destroy(gameObject);
        }
    }
    
}