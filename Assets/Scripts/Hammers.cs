using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Hammers : MonoBehaviour
{
    private Animator _animator;
    private string _selectedState;
    private string[] _arrayStates = new string[] { "State1", "State2", "State3"};

    private void Awake()
    {
        GlobalEvents.HitToPlayer.AddListener(StopAnimation);
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void SelectState()
    {
        _animator.SetBool(_selectedState, true);
    }

    public void StopAnimation()
    {
        _animator.SetBool(_selectedState, false);
    }

    private void RandomState()
    {
        System.Random rnd = new System.Random();
        _selectedState = _arrayStates[rnd.Next(_arrayStates.Length)];
        SelectState();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
            RandomState();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
            StopAnimation();
    }
}
