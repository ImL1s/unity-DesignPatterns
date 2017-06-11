/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  PBaseDefenseGame
 * 版本號：  V1.0.0.0
 * 唯一標識：e831b181-1665-469e-80d0-b4971fe720bb
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 11:20:48
 * 描述：
 * 
 */
using UnityEngine;


namespace YSFramework
{
	public delegate void EventCallBack(System.Object para);

	public class PBaseDefenseGame : YSObject, IPBaseDefenseGame
    {
        private static PBaseDefenseGame instance = null;

        private APSystem apSystem;
        private CampSystem campSystem;
        private StageSystem stageSystem;
        private GameEventSystem gameEventSystem;
        private CharacterSystem characterSystem;
        private AchievementSystem achievementSystem;

		private CampInfoUI campInfoUI;
		private SolidierInfoUI solidierInfoUI;
		private GameStateInfoUI gameStateInfoUI;

        private bool isGameOver;

        public static PBaseDefenseGame Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PBaseDefenseGame();
                }

                return instance;
            }
        }

        public void Initinal()
        {
            isGameOver = false;
            apSystem = new APSystem(this);
            campSystem = new CampSystem(this);
            stageSystem = new StageSystem(this);
            gameEventSystem = new GameEventSystem(this);
            characterSystem = new CharacterSystem(this);
            achievementSystem = new AchievementSystem(this);

			campInfoUI = new CampInfoUI (this);
			solidierInfoUI = new SolidierInfoUI (this);
        }

        internal void Update()
        {
			InputProcess ();
            apSystem.Update();
            campSystem.Update();
            stageSystem.Update();
            gameEventSystem.Update();
            characterSystem.Update();
            achievementSystem.Update();
        }

        public void Release()
        {
            apSystem.Release();
            campSystem.Release();
            stageSystem.Release();
            gameEventSystem.Release();
            characterSystem.Release();
            achievementSystem.Release();
        }

		void InputProcess ()
		{
			if (!Input.GetMouseButtonUp (0)) {
				return;
			}
		}

        public bool GameIsOver()
        {
            return isGameOver;
        }

        public int GetEnemyCount()
        {
            if (characterSystem != null)
                return characterSystem.GetEnemyCount();

            return 0;
        }

        public int GetUnitCount(ESolidier eSolider)
        {
            return characterSystem.GetUnitCount(eSolider);
        }

        public int GetUnitCount(EEnemy eEnemy)
        {
            return characterSystem.GetUnitCount(eEnemy);
        }

		public void ShowCampInfo(ICamp camp)
		{
			campInfoUI.ShowInfo (camp);
			solidierInfoUI.Hide ();
		}

		public void RegisterGameEvent(EGameEvent gameEvent,IGameEventObserver callback)
		{
			
		}

		public void RegisterGameEvent(EGameEvent gameEvent,EventCallBack callback)
		{

		}

		public void NotifyGameEvent(EGameEvent gameEvent, System.Object para)
		{

		}

		public void ChangeToMainMenu ()
		{
			
		}	
		public void GamePause ()
		{
			
		}

		

        public enum ESolidier
        {
            One, Two
        }

        public enum EEnemy
        {
            One, Two
        }

		public enum EGameEvent
		{
			Test
		}
    }
}
