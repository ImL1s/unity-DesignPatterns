using System;

namespace YSFramework
{
    internal class CharacterSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public CharacterSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new CharacterSystem(pBaseDefenseGame);
        }

        public void Release()
        {
        }

        public void Update()
        {
        }

        internal int GetEnemyCount()
        {
            return 1;
        }

        internal int GetUnitCount(PBaseDefenseGame.ESolidier eSolider)
        {
            return 1;
        }

        internal int GetUnitCount(PBaseDefenseGame.EEnemy eEnemy)
        {
            return 1;
        }
    }
}