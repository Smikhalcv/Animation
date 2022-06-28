using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace GlobalString 
{
    [RequireComponent(typeof(Collider))]
    public class Portal : MonoBehaviour
    {
        private int _numberCurrentScene;
        static private int CountSceneInBuild;

        private void Start()
        {
            _numberCurrentScene = SceneManager.GetActiveScene().buildIndex;
            CountSceneInBuild = SceneManager.sceneCountInBuildSettings;
        }


        /// <summary>
        /// Return number next scene, if that is last scene return 0 - MainMenu
        /// </summary>
        /// <returns>int - number next scene</returns>
        private int NumberNextScene()
        {
            if (_numberCurrentScene + 1 == CountSceneInBuild)
            {
                return 0;
            }
            return _numberCurrentScene + 1;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(GlobalStringVars.TagPlayer))
            {
                SceneManager.LoadScene(NumberNextScene());
            }
        }
    }
}

