using Microsoft.AspNetCore.Mvc;
using Ecard.Repositories.Portal.Functions;
using ECard.Repositories.Entity.Home;

namespace Eclub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EclubController : ControllerBase
    {

        [HttpGet]
        [Route("[action]")]
        public string Getter()
        {
            return "checker";
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<string> GetHomePageInfo()
        {
            HomePageInfoEntity homePageInfoEntity = new HomePageInfoEntity();
            homePageInfoEntity.CompanyName = "Parhamkish";
            //var foundSession = HttpContext.Session.GetString("User_");
            //var convertedSessionVal = JsonConvert.DeserializeObject<SessionValue>(foundSession);
            //var Token = convertedSessionVal.TokenID;

            var cardAPI = Global.GetUrl(Ecard.Repositories.Portal.Functions.Enumerable.URL.CardAPI);// Functions.Global.TourismAPI;
            File.WriteText("", "");
            var resultApi = await new Ecard.Repositories.Portal.Functions.MasterApi().CallApi(
                Ecard.Repositories.Portal.Functions.Extention.SetDictionaty(homePageInfoEntity),
                Ecard.Repositories.Portal.Functions.Extention.SetDictionaty(Ecard.Repositories.Portal.Functions.Extention.LogInfo(Request)),
                "GetHomePageInfo",
                "-1",
                cardAPI
            //Token,
            );

            return resultApi.Content;
        }
    }
}