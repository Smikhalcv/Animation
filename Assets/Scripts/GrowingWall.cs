using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingWall : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponentInChildren<Animator>();   
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
        {
            _anim.SetBool("NearBall", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
        {
            _anim.SetBool("NearBall", false);
        }
    }
}
