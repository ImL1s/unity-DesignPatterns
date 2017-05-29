/*
 * Copyright (c) 2017  All Rights Reserved.
 *
 * CLR版本： 4.0.30319.42000
 * 機器名稱：DESKTOP-IML1S
 * 文件名：  YSButton
 * 版本號：  V1.0.0.0
 * 唯一標識：55e97b7e-88a3-443d-ba9f-6bc19b9402d9
 * 創建人：  ImL1s
 * 電子郵箱：aa22396584@gmail.com
 * 創建時間：2017/5/29 下午 09:24:03
 * 描述：
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YSFramework
{
    public delegate void OnClickDelegate<T>(T v) where T : UIBehaviour;

    public class YSView<T>
        where T : UIBehaviour
    {
        private T view;

        public T View
        {
            get
            {
                return view;
            }

            set
            {
                view = value;
            }
        }

        public static YSView<T> Create(T view)
        {
            var ysView = new YSView<T>();
            ysView.View = view;
            return ysView;
        }

        public static YSView<T> Create(string name)
        {
            T view = UITool.GetUIComponent<T>(name);
            return Create(view);
        }

        public void OnClick(OnClickDelegate<T> onClick)
        {
            if (View is Button)
            {
                (View as Button).onClick.AddListener(() => onClick(View));
            }
            else
            {
                throw new IllegalOperationException("set click event on not button exception");
            }
        }
    }
}
