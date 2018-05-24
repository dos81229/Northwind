using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Utility
{
    public class AppHelper
    {
        /// <summary>
        /// 依key取得AppSetting值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSettingStr(string key)
        {
            var secretKey = System.Configuration.ConfigurationManager.AppSettings[key];
            return secretKey;
        }
    }
}