using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using ECard.Repositories.Entity;
using Eclub.Entity;

namespace Ecard.Repositories.Portal.Functions
{
    public  class MasterApi
    {
        public async Task<ApiResult> CallApi(Dictionary<string, string> bodyEntity, Dictionary<string, string> logEntity, string methodName = "Login", string userToken = "-1", string requestUrl = "-1")
        {
            if(requestUrl == "-1")
            {
                requestUrl = Global.GetUrl(Functions.Enumerable.URL.BaseURL);// Global.UrlBaseApi;
            }

            ApiResult ResultEntity = new ApiResult();
            ResultEntity.Result.ReturnValue = -1;
            ResultEntity.Result.ReturnValueMessage = "خطا در انجام عملیات";
            
            //ResultEntity.Result = new Result();
            Dictionary<string, string> BodyDictionary = new Dictionary<string, string>();
            try
            {
                BodyDictionary = bodyEntity.Concat(logEntity)
                    .ToLookup(x => x.Key, x => x.Value)
                    .ToDictionary(x => x.Key, g => g.First());

                ResultEntity.Result.ReturnValue = -1;
                ResultEntity.Result.ReturnValueMessage = "خطا در پردازش سرویس دهنده";

                var httpClient = new HttpClient();
                requestUrl = requestUrl + methodName;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                httpClient.DefaultRequestHeaders.Accept.Clear();

                if (methodName == "Login" || methodName == "GetPassword")
                {
                    string UserName;
                    if (!BodyDictionary.TryGetValue("UserName", out UserName))
                    {
                        UserName = "";
                    }
                    string Password;
                    if (!BodyDictionary.TryGetValue("Password", out Password))
                    {
                        Password = "";
                    }
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "{\"UserName\":\"" + UserName + "\",\"Password\":\"" + Password + "\"}");
                }

                else
                {

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "{\"Token\":\"" + userToken + "\"}");
                }

                    httpClient.DefaultRequestHeaders.Add("Authentication", "{\"PrivateKey\":\"" + Global.PrivateKey + "\"}");



                var stringPayload = JsonConvert.SerializeObject(BodyDictionary);
                var formcontent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(new Uri(requestUrl), formcontent);



                if (response.Content != null)
                {
                    ResultEntity.Content = await response.Content.ReadAsStringAsync();
                    ResultEntity.Result.ReturnValue = 0;
                    ResultEntity.Result.ReturnValueMessage = "عملیات با موفقیت انجام شد";
                }

                httpClient.Dispose();

            }
            catch (Exception ex)
            {
                var red = ex.Message;
                ResultEntity.Result.ReturnValue = -100;
                ResultEntity.Result.ReturnValueMessage = "خطا در پردازش سرویس دهنده";
            }

            return ResultEntity;
        }
    }
}
