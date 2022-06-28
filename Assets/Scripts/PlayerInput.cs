using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalString 
{
    [RequireComponent(typeof(BallMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private BallMovement _movement;
        private Vector3 _direction;
        private float _horizontal;
        private float _vertical;


        private void Start()
        {
            _movement = GetComponent<BallMovement>();
        }

        private void Update()
        {
            _horizontal = Input.GetAxis(GlobalStringVars.Horizontal);
            _vertical = Input.GetAxis(GlobalStringVars.Vertical);
            _direction = new Vector3(_horizontal, 0, _vertical).normalized;
        }

        void FixedUpdate()
        {
            _movement.Move(_direction);
        }
    }
}

