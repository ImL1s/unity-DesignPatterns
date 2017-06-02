using System;

namespace YSFramework
{
	internal class StageSystem :BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public StageSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new StageSystem(pBaseDefenseGame);
        }

//		public StageSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
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