using System;

namespace YSFramework
{
	internal class GameEventSystem : BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public GameEventSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new GameEventSystem(pBaseDefenseGame);
        }

//		public GameEventSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
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