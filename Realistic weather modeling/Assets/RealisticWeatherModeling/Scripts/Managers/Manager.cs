using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Managers
    {
        [System.Serializable]
        public class Manager : MonoBehaviour
        {
            public virtual void Begin() { }
            public virtual void End() { }
        }
    }
}