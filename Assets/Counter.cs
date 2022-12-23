using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GlobalString 
{
    public class Counter : MonoBehaviour
    {
        private DateTime _timeStart;
        public DateTime TimeStart { get { return _timeStart; } }
        [SerializeField]
        private Text _textCounter;


        private void Start()
        {
            _timeStart = DateTime.Now;
        }


        private void Update()
        {
            _textCounter.text = (DateTime.Now - _timeStart).ToString("\\ mm\\:ss");
        }
    }
}

