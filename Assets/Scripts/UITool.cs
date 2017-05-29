/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  UITool
 * 版本號：  V1.0.0.0
 * 唯一標識：e8f5d883-c794-4ecd-b4c8-2ed4db66db49
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 09:23:22
 * 描述：
 * 
 */

using System.Diagnostics;
using UnityEngine;

namespace YSFramework
{
    public class UITool
    {
        public static T GetUIComponent<T>(string name)
        {
            GameObject obj = GameObject.Find(name);
            if (obj == null)
            {
                StackFrame[] stacks = new StackTrace(true).GetFrames();
                UnityEngine.Debug.LogError(stacks[1].GetFileName());
                return default(T);
            }
            return obj.GetComponent<T>();
        }
    }
}
