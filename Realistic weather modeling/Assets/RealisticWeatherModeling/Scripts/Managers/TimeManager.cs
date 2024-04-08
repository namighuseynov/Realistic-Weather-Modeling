using RealisticWeatherModeling.Time;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Managers
    {
        public class TimeManager : Manager
        {
            [SerializeField] private Clock _clock;
            [SerializeField] private float _timeScale = 1;
            [SerializeField] private int _elapsedDay;
            [SerializeField] private Transform _sun;
            [SerializeField] private bool _timeFlowing;
            public AnimationCurve curve;
            public Clock Clock { get { return _clock; } }
            public float TimeScale { get { return _timeScale; }}

            public override void Begin()
            {
                _clock = new Clock(0, 0, 0);
                _clock.OnDayLeft += OnDayLeft;

            }

            private void Update()
            {
                float deltaTime = UnityEngine.Time.deltaTime * TimeScale;
                if (_timeFlowing)
                {
                    _clock.Update(deltaTime);
                }
            }

            private void OnDayLeft()
            {
                _elapsedDay += 1;
            }
        }
    }
}