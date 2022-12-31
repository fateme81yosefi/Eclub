using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecard.Repositories.Portal.Functions
{
    public static class Global
    {
        #region eclub External

        private static string UrlBase ;
        private static string UrlBaseApi = "/ClubApi/";    //"http://api.eclubgroup.ir/ClubApi/";
        private static string GeneralAPI = "/GeneralAPI/"; //"http://api.eclubgroup.ir/GeneralAPI/";
        private static string PickingAPI = "/PickingAPI/"; //"http://api.eclubgroup.ir/PickingAPI/";
        private static string PackageAPI = "/PackageAPI/"; //"http://api.eclubgroup.ir/PackageAPI/";
        private static string TourismAPI = "/Tourismapi/"; //"http://api.eclubgroup.ir/Tourismapi/";
        private static string ReportAPI = "/ReportAPI/";   //"http://api.eclubgroup.ir/Tourismapi/";
        private static string CardAPI = "/CardApi/";   //"http://api.eclubgroup.ir/CardAPI/";
        #endregion

        #region eclub Internal

        //internal static string UrlBaseApi = "http://172.28.1.16:9099/ClubAPI";
        //internal static string GeneralAPI = "http://172.28.1.16:9099/GeneralAPI";
        //internal static string PickingAPI = "http://172.28.1.16:9099/PickingAPI";
        //internal static string PackageAPI = "http://172.28.1.16:9099/PackageAPI";
        //internal static string TourismAPI = "http://172.28.1.16:9099/Tourismapi";
        #endregion

        #region bama External

        //internal static string UrlBaseApi = "http://bamaapi.ecomgroup.ir/ClubAPI";
        //internal static string GeneralAPI = "http://bamaapi.ecomgroup.ir/GeneralAPI";
        #endregion

        #region bama Internal

        //internal static string UrlBaseApi = "http://172.28.1.16:1020/ClubAPI";
        //internal static string GeneralAPI = "http://172.28.1.16:1020/GeneralAPI";
        #endregion

        #region shandiz External

        //internal static string UrlBaseApi = "http://api.shandiz.ir/ClubAPI";
        //internal static string GeneralAPI = "http://api.shandiz.ir/GeneralAPI";
        //internal static string PickingAPI = "http://api.shandiz.ir/PickingAPI";

        #endregion

        #region shandiz Internal
        //internal static string UrlBaseApi = "http://172.28.1.16:9091/ClubAPI";
        //internal static string GeneralAPI = "http://172.28.1.16:9091/GeneralAPI";
        //internal static string ShandizAPI = "http://172.28.1.16:9091/PickingAPI";

        #endregion

        public static void GetUrlBase()
        {
            try
            {
                if (UrlBase == null)
                    UrlBase = File.ReadAllText("URL.txt");
            }
            catch (Exception ex)
            {
                UrlBase = "http://api.ep7.ir/";

                //File.WriteAllText(@"d:\projects\log.txt", ex.Message);
            }
        }

        public static string  GetUrl(Enumerable.URL url)
        {
            string URLAPI = "";
            try
            {

                switch (url)
                {
                    case Enumerable.URL.BaseURL:
                        URLAPI = UrlBase + UrlBaseApi;
                        break;
                    case Enumerable.URL.GeneralURL:
                        URLAPI = UrlBase + GeneralAPI;

                        break;
                    case Enumerable.URL.PickingAPI:
                        URLAPI = UrlBase + PickingAPI;

                        break;
                    case Enumerable.URL.TourismAPI:
                        URLAPI = UrlBase + TourismAPI;

                        break;
                    case Enumerable.URL.PackageAPI:
                        URLAPI = UrlBase + PackageAPI;

                        break;
                    case Enumerable.URL.ReportAPI:
                        URLAPI = UrlBase + ReportAPI;
                        
                        break;

                    case Enumerable.URL.CardAPI:
                        URLAPI = UrlBase + CardAPI;

                        break;

                    default:
                        URLAPI = "";
                        break;
                }

            }
            catch (Exception)
            {
                URLAPI = "http://192.168.3.50:11024/";
            }
            return URLAPI;
        }

        internal static string PrivateKey = "Fr@n3t1@dg#dg$h4234fdg@d#f%d$^564&f%^3fs";

        internal static int shop = (int)Enumerable.Shop.parsSafari;
        internal static int appID = (int)Enumerable.AppID.parsSafari;
        internal static int shandizShop = (int)Enumerable.Shop.shandiz;

    }
}
