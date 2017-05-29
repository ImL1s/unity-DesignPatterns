/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  ISceneState
 * 版本號：  V1.0.0.0
 * 唯一標識：2c06b8a8-9659-443c-b9d4-109ef7712baf
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 07:08:43
 * 描述：
 * 
 */

namespace YSFramework
{
    public interface ISceneState
    {
        void StateBegin();

        void StateEnd();

        void StateUpdate();

        string SceneName { get; }

        SceneStateController SceneStateController { get; set; }
    }
}

