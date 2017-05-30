using System;

namespace YSFramework
{
    internal class StageSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public StageSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new StageSystem(pBaseDefenseGame);
        }

        public void Release()
        {
        }

        public void Update()
        {
        }
    }
}