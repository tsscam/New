using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace TESTAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetJsonData()

        {
            //GETTING THE RAW TEXT DATA from JSON
            HttpWebRequest request = WebRequest.CreateHttp("http://forecast.weather.gov/MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");

            request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

            //add a key to YOUR API call " X-MAShape from the WEBSITE YOUR "KEY" once you have account
            request.Headers.Add ("X-Mashape-Key", "235yfhefuibwjkhwr");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader (response.GetResponseStream());

            string data = rd.ReadToEnd();

            JObject WeatherData = JObject.Parse(data);

            //ViewBag.Message = WeatherData ["productionCenter"];

            //ViewBag.Message = WeatherData["location"]["timezone"];

            //sends the WHOLE ARRAY OF WEATHER...........
            ViewBag.Time = WeatherData["time"]["startPeriodName"];
            ViewBag.Message = WeatherData["data"]["weather"];

            return View("Weather");

        }
        public ActionResult GetXMLData()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://forecast.weather.gov/MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=xml");

            request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

            //add a key to YOUR API call " X-MAShape from the WEBSITE YOUR "KEY" once you have account
            request.Headers.Add("X-Mashape-Key", "235yfhefuibwjkhwr");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string data = rd.ReadToEnd();

            XmlDocument XMLdata = new XmlDocument();

            XMLdata.LoadXml(data); //Parse text

            // XMLdata ["Forcast"] ["period"] ["text"]

            ViewBag.TextData = XMLdata.GetElementsByTagName("text");
            ViewBag.Day = XMLdata.GetElementById("valid");

            return View("XMLWeather");

        }

    }
}