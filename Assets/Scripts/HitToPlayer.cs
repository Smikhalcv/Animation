using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GlobalString 
{
    [RequireComponent(typeof(Collider))]
    public class HitToPlayer : MonoBehaviour
    {

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(GlobalStringVars.TagPlayer))
            {
                GlobalEvents.HitToPlayer.Invoke();
            }
        }
    }
}

