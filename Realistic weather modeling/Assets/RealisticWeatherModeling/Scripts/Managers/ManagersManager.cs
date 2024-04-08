using System.Collections.Generic;

namespace RealisticWeatherModeling
{
    namespace Managers
    {
        public class ManagersManager : Manager
        {
            public List<Manager> managers = new List<Manager>();
            public override void Begin()
            {
                foreach (Manager manager in managers)
                {
                    manager.Begin();
                }
            }

            public override void End() { 
                foreach (Manager manager in managers)
                {
                    manager.End();
                }
            }

            private void OnApplicationQuit()
            {
                End();
            }

            private void Start()
            {
                Begin();
            }
        }
    }
}

