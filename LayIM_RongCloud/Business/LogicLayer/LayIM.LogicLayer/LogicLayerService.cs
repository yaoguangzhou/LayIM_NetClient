﻿using LayIM.DataAccessLayer;
using LayIM.DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayIM.LogicLayer
{
    /// <summary>
    /// 注册公共服务
    /// </summary>
    public class LogicLayerService
    {
        /// <summary>
        /// 注册服务
        /// </summary>
        public static void RegisterDataService()
        {
            DataAccessLayerService.RegisterService();
        }
    }
}
