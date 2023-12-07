using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Vector3 _targetScale;

    private Transform _transform;
    private Vector3 _scale;

    private void Awake()
    {
        _transform = transform;
        _scale = transform.lossyScale;
    }

    private void Update()
    {
        ScaleObject();
    }

    private void ScaleObject()
    {
        if (_transform.localScale == _targetScale)
        {
            Vector3 tempScale = _scale;
            _scale = _targetScale;
            _targetScale = tempScale;
        }

        _transform.localScale = Vector3.MoveTowards(_transform.localScale, _targetScale, _speed*Time.deltaTime);
    }
}
