using RealisticWeatherModeling.RealisticSkybox.Enum;
using UnityEngine;

namespace RealisticWeatherModeling
{
    namespace Managers
    {
        public class SeasonManager : Manager
        {
            [SerializeField] private TimeManager timeManager;
            public Season currentSeason;
            public void Simmulate()
            {

            }
            public override void Begin()
            {
                timeManager = GetComponent<TimeManager>();
            }

            public override void End()
            {
                base.End();
            }
        }
    }
}