using RealisticWeatherModeling.Time;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Manager
    {
        public class TimeManager : Manager
        {
            [SerializeField] private Clock _clock;
            private float _elapsedTime;
            [SerializeField] private float _timeScale = 1;
            [SerializeField] private int _elapsedDay;
            public AnimationCurve curve;
            public Clock Clock { get; private set; }
            public float TimeScale { get { return _timeScale; } private set { } }
            public override void Begin()
            {
                base.Begin();
            }
            public override void End() 
            { 
                base.End();
            }

            private void FixedUpdate()
            {
                float deltaTime = UnityEngine.Time.deltaTime * TimeScale;
                _elapsedTime += deltaTime;

                int _seconds = Mathf.FloorToInt(_elapsedTime % 60);
                int _minutes = Mathf.FloorToInt((_elapsedTime / 60) % 60);
                int _hours = Mathf.FloorToInt((_elapsedTime / 3600) % 24);
                int _day = Mathf.FloorToInt((_elapsedTime / 86400));
                if (_day == 1)
                {
                    _elapsedDay++;
                    _elapsedTime = 0;
                }

                float deltaAngle = deltaTime * 360 / 86400;
                //_sun.transform.Rotate(deltaAngle, 0, 0);
                _clock.Update(_hours, _minutes, _seconds);
                Debug.Log("here");
            }
        }
    }
}