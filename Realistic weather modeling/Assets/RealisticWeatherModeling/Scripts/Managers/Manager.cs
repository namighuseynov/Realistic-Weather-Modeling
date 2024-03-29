using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Manager
    {
        [System.Serializable]
        public class Manager : MonoBehaviour
        {
            public virtual void Begin() { }
            public virtual void End() { }
        }
    }
}