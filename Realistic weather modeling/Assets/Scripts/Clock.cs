using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Time
    {
        [System.Serializable]
        public class Clock
        {
            public int Hour;
            public int Minute;
            public int Seconds;

            private int _initialHour = 0;
            private int _initialMinute = 0;
            private int _initialSecond = 0;
            private float _elapsedTime = 0;

            public Clock(int hour, int minute, int second)
            {
                _initialHour = hour;
                _initialMinute = minute;
                _initialSecond = second;
                _elapsedTime = (_initialSecond * 60) + (_initialMinute * 60 * 60) + (_initialHour * 60 * 60 * 60);
            }

            public void Update(float deltaTime)
            {
                _elapsedTime += deltaTime;
                Seconds = Mathf.FloorToInt(_elapsedTime % 60);
                Minute = Mathf.FloorToInt((_elapsedTime / 60) % 60);
                Hour = Mathf.FloorToInt((_elapsedTime / 3600) % 24);

            }

            public void Update(int elapsedHour, int elapsedMinute, int elapsedSecond)
            {
                Hour = _initialHour + elapsedHour;
                Minute = _initialMinute + elapsedMinute;
                Seconds = _initialSecond + elapsedSecond;
            }
        }
    }
}