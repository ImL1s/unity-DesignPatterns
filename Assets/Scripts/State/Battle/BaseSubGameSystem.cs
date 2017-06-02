using System;

namespace YSFramework
{
	public class BaseSubGameSystem : YSObject,ISubGameSystem
	{
		protected IPBaseDefenseGame pBaseDefenseGame;

		public BaseSubGameSystem (IPBaseDefenseGame pBaseDefenseGame)
		{
			this.pBaseDefenseGame = pBaseDefenseGame;
		}

		#region ISubGameSystem implementation

		public virtual void Initialize ()
		{
		}

		public virtual void Update ()
		{
		}

		public virtual void Release ()
		{
		}

		#endregion
	}
}

