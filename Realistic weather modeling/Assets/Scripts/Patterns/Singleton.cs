using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RealisticWeatherModeling
{
    namespace Patterns
    {
        public class Singleton<T> : MonoBehaviour
        {
            protected static T instance;

            public static T Instance { get { return instance; } private set { } }
        }
    }
}