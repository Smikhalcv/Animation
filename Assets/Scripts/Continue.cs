using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(GlobalEvents.OffPause.Invoke);
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
