/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  IllegalOperationException
 * 版本號：  V1.0.0.0
 * 唯一標識：322d344e-c3d4-4b67-b1da-9370f4ad31db
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 11:13:04
 * 描述：
 * 
 */

using System;

namespace YSFramework
{
    public class IllegalOperationException : Exception
    {
        public IllegalOperationException(string message) : base(message)
        {
        }
    }
}
