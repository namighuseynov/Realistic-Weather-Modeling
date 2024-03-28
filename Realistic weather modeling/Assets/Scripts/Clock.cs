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

            public Clock(int hour, int minute, int second)
            {
                _initialHour = hour;
                _initialMinute = minute;
                _initialSecond = second;
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