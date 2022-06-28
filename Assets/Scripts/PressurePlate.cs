using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace GlobalString
{
    [RequireComponent(typeof(Collider))]
    public class PressurePlate : MonoBehaviour
    {
        [SerializeField] private Text _massegeForPlayer;
        [SerializeField] private GameObject _object;

        private void Start()
        {
            _object.SetActive(false);
            _massegeForPlayer.text = null;
        }

        private void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.CompareTag(GlobalStringVars.TagPlayer))
            {
                _massegeForPlayer.text = "E";
                if (Input.GetKeyDown(KeyCode.E))
                    _object.SetActive(true);
            }            
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag(GlobalStringVars.TagPlayer))
                _massegeForPlayer.text = null;
        }
    }
}

