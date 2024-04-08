using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace RealisticSkybox
    {
        [CreateAssetMenu(fileName = "Skybox", menuName = "ScriptableObjects/Skybox", order = 1)]
        public class Skybox : ScriptableObject
        {
            public Material skyboxShader;

            public void SetColor(string parameter, Color32 color)
            {
                skyboxShader.SetColor(parameter, color);
            }
        }
    }
}