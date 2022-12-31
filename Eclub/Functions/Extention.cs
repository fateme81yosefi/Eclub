using ECard.Repositories.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace Ecard.Repositories.Portal.Functions
{
    public static class Extention
    {
        public static LogEntity LogInfo(HttpRequest Request)
        {
            LogEntity le = new LogEntity()
            {
                Resolution = "500*500",
                Browser = Request.Headers["User-Agent"].ToString(),
                BrowserVersion = "192.168.1.1",
                IP = "192.168.1.1",
                Host = "192.168.1.1",
                MacAddress = "15:54:21:32:12",
                OS = "test",
                //Browser = Request.Browser.Id,
                //BrowserVersion = Request.Browser.Version,
                //IP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? Request.UserHostAddress,
                //Host = Request.UserHostAddress,
                //MacAddress = (
                //    from nic in NetworkInterface.GetAllNetworkInterfaces()
                //    where nic.OperationalStatus == OperationalStatus.Up
                //    select nic.GetPhysicalAddress().ToString()
                //).FirstOrDefault(),
                //OS = Request.UserAgent,
                AppID = Global.appID
            };

            return le;
        }

        internal static Dictionary<string, string> SetDictionaty()
        {
            throw new NotImplementedException();
        }

        public static Dictionary<string, string> SetDictionaty(object entity)
        {

            PropertyInfo[] propertyInfo = entity.GetType().GetProperties();

            Dictionary<string, string> d = new Dictionary<string, string>();
            foreach (var item in propertyInfo)
            {
                try
                {
                    if(item.GetValue(entity, null)!=null)
                    d.Add(item.Name, item.GetValue(entity, null).ToString());
                }
                catch (Exception)
                {

                }
            }

            return d;
        }
    }
}
