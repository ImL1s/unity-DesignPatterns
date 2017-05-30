using System;

namespace YSFramework
{
    internal class AchievementSystem : YSObject, ISubSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

        public AchievementSystem(IPBaseDefenseGame pBaseDefenseGame)
        {
            LogD("new AchievementSystem()");
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new AchievementSystem(pBaseDefenseGame);
        }

        public void Release()
        {
            LogD("release");
        }

        public void Update()
        {
            
        }
    }
}