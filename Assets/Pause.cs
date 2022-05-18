using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pause : MonoBehaviour
{
    private Button _button;
    [SerializeField] private Canvas _pauseMune;


    public static UnityEvent OffPause;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(GamePause);
        
    }

    private void Start()
    {


        GlobalEvents.OffPause.AddListener(TurnOffPause);
    }

    
    // Update is called once per frame
    void Update()
    {
/*        if (_pauseMune.isActiveAndEnabled)
        {
            _button.interactable = false;
        }
        else
        {
            _button.interactable = true;
        }*/
    }

    private void GamePause()
    {
        Time.timeScale = 0;
        _pauseMune.gameObject.SetActive(true);
        _button.interactable = false;
    }

    private void TurnOffPause()
    {
        Time.timeScale = 1;
        _pauseMune.gameObject.SetActive(false);
        _button.interactable = true;
    }
}
