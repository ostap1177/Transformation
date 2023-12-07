using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        RotationObject();
    }

    private void RotationObject()
    {
        _transform.Rotate(0,_speed*Time.deltaTime,0,Space.World);
    }
}
