/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  MainMenuScene
 * 版本號：  V1.0.0.0
 * 唯一標識：f8eaede2-e4b6-469b-9ac4-6741f337f305
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 08:20:10
 * 描述：
 * 
 */

using System;
using UnityEngine.UI;

namespace YSFramework
{
    public class MainMenuScene : BaseSceneState
    {
        public MainMenuScene() : base() { }

        public MainMenuScene(SceneStateController controller) : base(controller) { }

        public override string GetSceneName()
        {
            return "MainMenuScene";
        }

        public override void StateBegin()
        {
            UnityEngine.Debug.Log("MainMenuScene scene StateBegin");

            YSView<Button> button = YSView<Button>.Create("StartGameBtn");

            button.OnClick(v =>
            {
                SceneStateController.SetState(new BattleState());
            });
        }
    }
}

