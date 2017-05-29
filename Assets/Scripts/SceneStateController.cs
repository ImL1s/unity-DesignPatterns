/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  SceneStateController
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
using UnityEngine.SceneManagement;

namespace YSFramework
{
    public class SceneStateController
    {
        ISceneState sceneState;
        AsyncOperation loadSceneOperation;
        bool isBegin = false;

        internal void SetState(ISceneState state)
        {
            if (loadSceneOperation != null && !loadSceneOperation.isDone)
            {
                return;
            }
            if (sceneState != null)
            {
                sceneState.StateEnd();
            }

            LoadScene(state);
        }

        private void LoadScene(ISceneState state)
        {
            this.sceneState = state;
            if (sceneState.SceneStateController == null)
            {
                sceneState.SceneStateController = this;
            }
            //SceneManager.LoadScene(state.SceneName);
            loadSceneOperation = SceneManager.LoadSceneAsync(state.SceneName);
            isBegin = false;
        }

        internal void StateUpdate()
        {
            if (loadSceneOperation == null || !loadSceneOperation.isDone)
                return;

            if (!isBegin)
            {
                sceneState.StateBegin();
                isBegin = true;
            }

            sceneState.StateUpdate();
        }
    }
}

