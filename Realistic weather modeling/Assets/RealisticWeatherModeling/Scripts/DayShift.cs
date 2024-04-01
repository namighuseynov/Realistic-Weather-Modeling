using RealisticWeatherModeling.Manager;
using UnityEngine;
using static UnityEditor.AnimationUtility;

namespace RealisticWeatherModeling
{
    namespace Time
    {
        public class DayShift : MonoBehaviour
        {
            public AnimationCurve curve;
            public Transform sun;
            public TimeManager timeManager;
            public Clock SunriseTime;
            public Clock SunsetTime;
           
            private void Start()
            {
                curve = new AnimationCurve(new Keyframe(CalculateCurveTime(SunriseTime.Hour, SunriseTime.Minute, SunriseTime.Seconds), 0),
                    new Keyframe(CalculateCurveTime(SunsetTime.Hour, SunsetTime.Minute, SunsetTime.Seconds), 0.5f),
                    new Keyframe(1.0f, 1.0f));
                curve.preWrapMode = WrapMode.Loop;
                SetKeyLeftTangentMode(curve, 0, TangentMode.Linear);
                SetKeyLeftTangentMode(curve, 1, TangentMode.Linear);
                SetKeyLeftTangentMode(curve, 2, TangentMode.Linear);
                SetKeyRightTangentMode(curve, 0, TangentMode.Linear);
                SetKeyRightTangentMode(curve, 1, TangentMode.Linear);
                SetKeyRightTangentMode(curve, 2, TangentMode.Linear);
            }

            private void FixedUpdate()
            {
                RotateSun();
            }

            private float CalculateCurveTime(float hour, float minute, float second)
            {
                float time = hour + ((minute * 5.0f / 3.0f) / 100.0f);
                float sunriseTime = SunriseTime.Hour + ((SunriseTime.Minute * 5.0f / 3.0f) / 100.0f);
                if (time < sunriseTime) time += 24;
                float value = time / (sunriseTime + 24);
                return value;
            }
            private float GetSolarEulerAngle(float value)
            {
                float solarEulerAngle = curve.Evaluate(value) * 360.0f;
                return solarEulerAngle;
            }

            private void RotateSun()
            {
                float value = CalculateCurveTime(timeManager.Clock.Hour, timeManager.Clock.Minute, timeManager.Clock.Seconds);
                float solarEulerAngle = GetSolarEulerAngle(value);
                Quaternion rot = Quaternion.Euler(new Vector3(solarEulerAngle, 0, 0));
                sun.rotation = rot;
            }
        }
    }
}