using System;

namespace YSFramework
{
    internal class GameEventSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public GameEventSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new GameEventSystem(pBaseDefenseGame);
        }

        public void Release()
        {
        }

        public void Update()
        {
        }
    }
}