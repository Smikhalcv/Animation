using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammers : MonoBehaviour
{
    private Animator _animator;
    private string _selectedState;
    private string[] _arrayStates = new string[] { "State1", "State2", "State3"};


    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SelectState(string state)
    {
        _animator.SetBool(state, true);
    }

    private void StopAnimation(string state)
    {
        _animator.SetBool(state, false);
    }

    private void RandomState()
    {
        System.Random rnd = new System.Random();
        _selectedState = _arrayStates[rnd.Next(_arrayStates.Length)];
        Debug.Log(_selectedState);
        SelectState(_selectedState);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
            RandomState();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MagmaBall"))
            StopAnimation(_selectedState);
    }
}
