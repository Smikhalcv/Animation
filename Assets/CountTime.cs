using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTime : MonoBehaviour
{
    private Dictionary<int, TimeSpan> _dCountTime = new Dictionary<int, TimeSpan>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTime(int LevelNumber, TimeSpan LapTime)
    {
        _dCountTime[LevelNumber] = LapTime;
        foreach (var item in _dCountTime)
        {
            Debug.Log($"{item.Key} - {item.Value}");
        }
    }
}
