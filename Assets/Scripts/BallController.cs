using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _speed, _step;
    [SerializeField] private float _speedRot;
    private Rigidbody _rb;


    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMove, 0.0f, verticalMove);
        _rb.AddForce(movement * _speed);
    }


}
