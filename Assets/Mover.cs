using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Vector3 _targetPosition;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_targetPosition.z == _transform.position.z)
        {
            _targetPosition.z *= -1;
        }

        _transform.position = Vector3.MoveTowards(transform.position,_targetPosition, _speed*Time.deltaTime);
    }
}
