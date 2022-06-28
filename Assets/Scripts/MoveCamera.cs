using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    private Vector3 _distance;
    

    private void Start()
    {
        _distance = transform.position - _ballTransform.position;
    }

    private void FixedUpdate()
    {
        transform.position = _ballTransform.position + _distance;
    }
}
