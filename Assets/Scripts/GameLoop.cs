/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  GameLoop
 * 版本號：  V1.0.0.0
 * 唯一標識：2c06b8a8-9659-443c-b9d4-109ef7712baf
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 07:08:43
 * 描述：
 * 
 */

using System;
using UnityEngine;

namespace YSFramework
{
    public class GameLoop : MonoBehaviour
    {
        SceneStateController sceneStateController = null;
        private bool isInit = false;

        void Awake()
        {
            Log("Awake End");

            if (!isInit)
            {
                Log("Init Start");

                isInit = true;

                InitSetting();
                InitSubSystem();
                BaseSceneState init = BaseSceneState.Create<InitScene>(sceneStateController);
                sceneStateController.SetState(init);

                Log("Init End");
            }

            Log("Awake End");
        }

        private void InitSetting()
        {
            DontDestroyOnLoad(this.gameObject);
            UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
        }

        void Start()
        {
            Log("Start Start");
            Log("Start End");
        }

        void Update()
        {
            sceneStateController.StateUpdate();
        }

        private void InitSubSystem()
        {
            sceneStateController = new SceneStateController();
        }

        protected void Log(string msg)
        {
            LogUtil.D(msg, this);
            //Debug.Log(string.Format("[{0}] {1}", GetType().Name, msg));
        }
    }
}
