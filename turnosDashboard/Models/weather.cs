﻿using Json;
using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnosDashboard.Models
{
     class strctWeather {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string temp;
        public string Temp
        {
            get { return temp; }
            set {
                temp = Math.Round((Decimal)(float.Parse(value) - 273.15), 0, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private string urlIcon;
        public string UrlIcon
        {
            get { return urlIcon; }
            set { urlIcon = value; }
        }
    }

    static class weather
    {
        private static string weatherURL = "http://api.openweathermap.org/data/2.5/";
        private static string method = "weather?q=${value}";

        public static strctWeather get(string value)
        {
            strctWeather model = null;
            try
            {
                string invoke = weatherURL;
                
                RestClient client = new RestClient(invoke);
                client.Timeout = 10000;

                var request = new RestRequest(method.Replace("${value}", value), Method.GET);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request) as RestResponse;

                var data = JsonParser.Deserialize(response.Content);

                model = new strctWeather();
                model.Name = data.name.ToString();
                model.Temp = data.main.temp.ToString();                    

                foreach (var item in data.weather)
                {
                    model.UrlIcon = string.Format("{0}{1}.png", "http://openweathermap.org/img/w/", item["icon"].ToString());                        
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                return null;
            }
            return model;
        }

        public static List<caWeathers> getCaWeathers() {
            DBDataContext db = new DBDataContext();
            return db.caWeathers.ToList();
        }
        
    }
}
