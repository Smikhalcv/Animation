using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private GameObject _magmaBall;
    private Vector3 _cameraPos;
    [SerializeField] private float _step;
    [SerializeField] private float _distanceToBall;
    [SerializeField] private float _heigthAboveBall;

    private void Start()
    {
        _magmaBall = GameObject.FindGameObjectWithTag("MagmaBall");
    }
    private void LateUpdate()
    {
        _cameraPos = _magmaBall.transform.position;
        _cameraPos.z -= _distanceToBall;
        _cameraPos.y += _heigthAboveBall;
       
        transform.position = _cameraPos;
    }
}
