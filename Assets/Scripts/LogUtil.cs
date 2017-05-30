/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  LogUtil
 * 版本號：  V1.0.0.0
 * 唯一標識：2068c46c-6937-4cfe-aa43-539715ecfc70
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/30 下午 08:22:11
 * 描述：
 * 
 */

using UnityEngine;

namespace YSFramework
{
    public class LogUtil
    {
        public static void D(string msg, object type)
        {
            Debug.Log(string.Format("<color=yellow>[Debug]</color> [{0}] {1}", type.GetType().Name, msg));
        }
    }
}
