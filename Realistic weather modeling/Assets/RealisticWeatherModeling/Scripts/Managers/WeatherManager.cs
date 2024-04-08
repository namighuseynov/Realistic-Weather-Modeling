using RealisticWeatherModeling.RealisticSkybox;
using RealisticWeatherModeling.RealisticSkybox.Enum;
using RealisticWeatherModeling.Time;
using RealisticWeatherModeling.Managers;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Managers 
    {
        public class WeatherManager : Manager
        {
            [SerializeField] private TimeManager _timeManager;
            [SerializeField] private DayShift _dayShift;
            [SerializeField] private SkyboxSettings _skyboxSettings;
            [SerializeField] private SeasonManager _seasonManager;
            [SerializeField] private WeatherType _currentWeather;
            [SerializeField] private RealisticSkybox.Skybox _skyBox;
            [SerializeField] private int _skyBoxIndex;

            




            public override void Begin()
            {
                _timeManager = GetComponent<TimeManager>();
                GenerateSkybox(_seasonManager.currentSeason, _currentWeather);
            }

            public void GenerateSkybox(Season season, WeatherType weather)
            {
                _skyBoxIndex = 0;
                for (int i = 0; i < _skyboxSettings.Properties.Count; i++)
                {
                    if (_skyboxSettings.Properties[i].weather == weather && _skyboxSettings.Properties[i].season == season) {
                        _skyBoxIndex = i;
                        break;
                    }   
                }
                
                _skyBox.SetColor("_SkyNightColor", _skyboxSettings.Properties[_skyBoxIndex].colors[0]);
            }
        }
    }
}