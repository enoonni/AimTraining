using System;
using UnityEngine;

namespace Gameplay
{
    public class Stopwatch
    {
        private static float _currentTime;
        private bool _isWorks;

        public delegate void TimeChangedEventHandler(object sender, float currentTime);
        public event TimeChangedEventHandler OnTimeChanged;
        public Stopwatch()
        {
            _currentTime = 0;
        }
        public void CountTime()
        {
            if(_isWorks)
            {
                var lastTime = _currentTime;
                _currentTime += Time.deltaTime;

                if((_currentTime - lastTime) >= (1.0f))
                {
                    OnTimeChanged?.Invoke(this, _currentTime);
                }
            }
        }

        public void Start()
        {
            _isWorks = true;
        }

        public void Stop()
        {
            _isWorks = false;
        }
    }
}
