using RealisticWeatherModeling.RealisticSkybox.Enum;
using System.Collections.Generic;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace RealisticSkybox
    {
        namespace Property 
        {
            [System.Serializable]
            public class SkyboxProperties
            {
                public Season season;
                public WeatherType weather;
                public List<Color> colors = new List<Color>();
                public AnimationCurve curve;
            }
        }
    }
}