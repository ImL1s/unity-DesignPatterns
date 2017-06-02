using System;

namespace YSFramework
{
	internal class APSystem : BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public APSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new APSystem(pBaseDefenseGame);
        }

//		public APSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
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