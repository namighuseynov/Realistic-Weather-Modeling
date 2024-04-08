using UnityEngine;
using RealisticWeatherModeling.Managers;
using RealisticWeatherModeling.Time;

namespace RealisticWeatherModeling
{
    namespace RealisticSkybox
    {
        namespace Managers
        {
            public class SkyboxManager : Manager
            {
                [SerializeField] private TimeManager     _timeManager;
                [SerializeField] private WeatherManager  _weatherManager;
                [SerializeField] private SeasonManager   _seasonManager;
                [SerializeField] private DayShift        _dayShift;
                [SerializeField] private Skybox          _skybox;

                private Color32 _skyboxColor;

                private void UpdateSkybox()
                {
                    //float dayDuration = _dayShift.DayDuration;
                    //float cycleProgress = _timeManager.Clock.ElapsedTime / dayDuration;
                    //if (_dayShift.IsDay)
                    //{
                    //    _skyboxColor = Color32.Lerp(Color.white, Color.black, dayDuration);
                    //}
                    //else
                    //{
                    //    _skyboxColor = Color32.Lerp(Color.black, Color.white, Mathf.Abs(24 - dayDuration));
                    //}
                    //_skybox.SetColor("_SkyNightColor", lerpedColor);
                    //Debug.Log(cycleProgress);
                }

                private void Update()
                {
                    UpdateSkybox();
                }

                public override void Begin()
                {
                    Color32 startedColor = Color32.Lerp(Color.white, Color.black, 0.5f);
                    float duration = _dayShift.IsDay ? _dayShift.DayDuration : Mathf.Abs(_dayShift.DayDuration - 24);
                    //float elapsedTime = 
                    //_skybox.SetColor("_SkyNightColor", startedColor);
                }

                public override void End() { base.End();}
            }
        }
    }
}