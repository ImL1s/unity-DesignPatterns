/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  YSObject
 * 版本號：  V1.0.0.0
 * 唯一標識：4ac0c2ad-364b-4368-867e-e6d6a9220126
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/30 下午 08:21:31
 * 描述：
 * 
 */


namespace YSFramework
{
    public class YSObject
    {
        public void LogD(string msg)
        {
            LogUtil.D(msg, this);
        }
    }
}
