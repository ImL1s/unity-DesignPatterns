using System;

namespace YSFramework
{
	internal class AchievementSystem : BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public AchievementSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            LogD("new AchievementSystem()");
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new AchievementSystem(pBaseDefenseGame);
        }

//		public AchievementSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
//		{
//		}

		public override void Initialize()
		{

		}

		public override void Release()
		{

		}

		public override void Update()
		{

		}
    }
}