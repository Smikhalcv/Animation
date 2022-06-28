using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    private Rigidbody _rgBall;
    [SerializeField, Range(100, 500)]
    private float _speed = 300f;
    private Vector3 _startPosition;

    private void Awake()
    {
        GlobalEvents.HitToPlayer.AddListener(SkipPlayer);
    }

    private void Start()
    {
        _startPosition = transform.position;
        _rgBall = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _rgBall.AddForce(direction * _speed);
    }

    private void SkipPlayer()
    {
        transform.position = _startPosition;
    }

#if UNITY_EDITOR
    [ContextMenu("Reset Speed")]
    public void ResetSpeed()
    {
        _speed = 300f;
    }

#endif
}
