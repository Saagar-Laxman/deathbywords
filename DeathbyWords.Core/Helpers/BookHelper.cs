using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using DeathByWords.Core.Models;
using DeathbyWords.Services.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DeathByWords.Web.Helpers
{
    public static class BookHelper
    {
        public static string ConstructRecommendationsShelfUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["ToReadShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];

            return baseUrl + shelfUrl + "?key=" + key;
        }
        public static string ConstructHaveReadAndReviewedShelfUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["HaveReadShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];

            return baseUrl + shelfUrl + "?key=" + key;
        }
        public static string ConstructCurrentlyReviewingShelfUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["ReadingShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];

            return baseUrl + shelfUrl + "?key=" + key;
        }
        public static string ConstructRecommendationsVolumesUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["ToReadShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];
            string volumesUrl = ConfigurationManager.AppSettings["volumeUrl"];
            return baseUrl + shelfUrl + volumesUrl + "?key=" + key;
        }
        public static string ConstructReadAndReviewedVolumesUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["HaveReadShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];
            string volumesUrl = ConfigurationManager.AppSettings["volumeUrl"];
            return baseUrl + shelfUrl + volumesUrl + "?key=" + key;
        }
        public static string ConstructCurrentlyReviewingVolumesUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseURL"];
            string shelfUrl = ConfigurationManager.AppSettings["ReadingShelfURL"];
            string key = ConfigurationManager.AppSettings["GoogleBooksAPIKey"];
            string volumesUrl = ConfigurationManager.AppSettings["volumeUrl"];
            return baseUrl + shelfUrl + volumesUrl + "?key=" + key;
        }

        public static Shelf GetShelf(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse webResponse = request.GetResponse();
            Stream responseStream = webResponse.GetResponseStream();
            if (responseStream != null)
            {
                StreamReader responseReader = new StreamReader(responseStream, Encoding.UTF8);
                string responseString = responseReader.ReadToEnd();
                Shelf myshelf = JsonConvert.DeserializeObject<Shelf>(responseString);
                return myshelf;
            }
            return new Shelf();
        }

    }
}