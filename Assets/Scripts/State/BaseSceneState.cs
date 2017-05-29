/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  BaseSceneState
 * 版本號：  V1.0.0.0
 * 唯一標識：2c06b8a8-9659-443c-b9d4-109ef7712baf
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 07:08:43
 * 描述：
 * 
 */

using System;

namespace YSFramework
{
    public abstract class BaseSceneState : ISceneState
    {
        public static BaseSceneState Create<T>(SceneStateController controller)
            where T : BaseSceneState, new()
        {
            T state = new T();
            state.SceneStateController = controller;
            return state;
        }

        public string SceneName { get; protected set; }

        public SceneStateController SceneStateController { get; set; }


        public BaseSceneState()
        {
            this.SceneName = GetSceneName();
        }

        public BaseSceneState(SceneStateController controller) : this()
        {
        }

        public abstract string GetSceneName();


        public virtual void StateBegin()
        {
        }

        public virtual void StateEnd()
        {
        }

        public virtual void StateUpdate()
        {
        }

        public override string ToString()
        {
            return string.Format("[SceneState: state name={0}]", SceneName);
        }
    }
}

