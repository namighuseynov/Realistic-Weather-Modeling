using RealisticWeatherModeling.RealisticSkybox.Property;
using System.Collections.Generic;
using UnityEngine;


namespace RealisticWeatherModeling
{
    namespace RealisticSkybox
    {
        [CreateAssetMenu(fileName = "SkyboxSettings", menuName = "ScriptableObjects/SkyboxSettings", order = 1)]
        public class SkyboxSettings : ScriptableObject
        {
            public List<SkyboxProperties> Properties = new List<SkyboxProperties>();
        }
    }
}