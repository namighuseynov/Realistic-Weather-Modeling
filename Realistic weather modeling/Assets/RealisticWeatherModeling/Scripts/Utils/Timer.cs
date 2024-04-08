using System;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Utils
    {
        public class Timer
        {
            public event Action OnTimerEnd;
            private MonoBehaviour _monoBehaviour;
            private float _elapsedTime = 0;
            private float _targetTime = 0;
            public float ElapsedTime { get { return _elapsedTime; } }
            public float TargetTime { get { return _targetTime; } }
            public Timer(float seconds, MonoBehaviour monoBehaviour)
            {
                _targetTime = seconds;
                _monoBehaviour = monoBehaviour;
                _monoBehaviour.StartCoroutine(UpdateTimer());
            }

            private System.Collections.IEnumerator UpdateTimer()
            {
                _elapsedTime = 0;
                while (_elapsedTime < _targetTime)
                {
                    yield return null;
                    _elapsedTime += UnityEngine.Time.deltaTime;
                }

                OnTimerEnd?.Invoke();
            }

            public void ResetTimer()
            {
                _monoBehaviour.StopAllCoroutines();
                _monoBehaviour.StartCoroutine(UpdateTimer());
            }

            public void Wait(float seconds)
            {
                _targetTime = seconds;
            }
        }
    }
}