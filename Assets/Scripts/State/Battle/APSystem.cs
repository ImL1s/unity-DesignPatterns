using System;

namespace YSFramework
{
    internal class APSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public APSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new APSystem(pBaseDefenseGame);
        }

        public void Release()
        {
        }

        public void Update()
        {

        }
    }
}