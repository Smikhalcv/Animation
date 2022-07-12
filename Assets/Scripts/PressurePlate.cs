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
        [SerializeField] ParticleSystem _effectPress;

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
                if (Input.GetKeyDown(KeyCode.E) && !_object.activeInHierarchy)
                {
                    _object.SetActive(true);
                    _effectPress.Play();
                }

                    
            }            
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag(GlobalStringVars.TagPlayer))
                _massegeForPlayer.text = null;
        }
    }
}

