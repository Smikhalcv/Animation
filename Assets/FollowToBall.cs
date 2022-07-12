using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToBall : MonoBehaviour
{
    [SerializeField] private Transform _posBall;


    private void Update()
    {
        transform.position = _posBall.position;
    }
}
