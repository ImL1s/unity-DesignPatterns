using System;

namespace YSFramework
{
	internal class CharacterSystem : BaseSubGameSystem
    {
        private IPBaseDefenseGame pBaseDefenseGame;

		public CharacterSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public static ISubGameSystem Create(IPBaseDefenseGame pBaseDefenseGame)
        {
            return new CharacterSystem(pBaseDefenseGame);
        }

//		public CharacterSystem(IPBaseDefenseGame pBaseDefenseGame):base(pBaseDefenseGame)
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