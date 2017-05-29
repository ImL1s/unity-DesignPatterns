/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  InitScene
 * 版本號：  V1.0.0.0
 * 唯一標識：f8eaede2-e4b6-469b-9ac4-6741f337f305
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 08:20:10
 * 描述：
 * 
 */

using System;
using System.Diagnostics;
using UnityEngine.UI;

namespace YSFramework
{
    public class InitScene : BaseSceneState
    {
        public InitScene() : base() { }


        public InitScene(SceneStateController controller) : base(controller) { }


        public override void StateBegin()
        {
            UnityEngine.Debug.Log("Init scene StateBegin");
            // init game

            // do not set scene state in begin method
            //SceneStateController.SetState(Create<MainMenuScene>(SceneStateController));

        }

        public override void StateUpdate()
        {
            SceneStateController.SetState(Create<MainMenuScene>(SceneStateController));
        }

        public override void StateEnd()
        {

        }

        public override string GetSceneName()
        {
            return "InitScene";
        }
    }
}

