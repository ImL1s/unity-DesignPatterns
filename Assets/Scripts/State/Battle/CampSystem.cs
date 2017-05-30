using System;

namespace YSFramework
{
    internal class CampSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public CampSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new CampSystem(pBaseDefenseGame);
        }

        public void Release()
        {
        }

        public void Update()
        {
        }
    }
}