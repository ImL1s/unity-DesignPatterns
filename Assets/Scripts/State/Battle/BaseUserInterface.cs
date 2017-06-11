using System;

namespace YSFramework
{
	public class BaseUserInterface : IUserInterface
	{
		protected IPBaseDefenseGame mediator;
		private bool isVisble;

		public BaseUserInterface (IPBaseDefenseGame pBaseDefenseGame)
		{
			this.mediator = pBaseDefenseGame;
		}

		public virtual bool IsVisble()
		{
			return isVisble;
		}

		public virtual void Show()
		{
			
		}

		public virtual void Hide()
		{
			
		}

		#region IUserInterface implementation
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

