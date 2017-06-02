using System;

namespace YSFramework
{
    internal class CampSystem : BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public CampSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new CampSystem(pBaseDefenseGame);
        }

//		public CampSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
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