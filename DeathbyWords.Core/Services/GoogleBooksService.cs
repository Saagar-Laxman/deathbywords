using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using DeathByWords.Core.Models;
using DeathByWords.Web.Helpers;
using DeathbyWords.Services.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace DeathbyWords.Core.Services
{
    public class GoogleBooksService
    {
        public enum Shelves
        {
            Recommendations,
            Read,
            Current
        }


        public static List<Book> getRecommendations()
        {
            string url = BookHelper.ConstructRecommendationsVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }


        public static List<Book> getCurrent()
        {
            string url = BookHelper.ConstructCurrentlyReviewingVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }


        public static List<Book> getRead()
        {
            string url = BookHelper.ConstructReadAndReviewedVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }
        //public static List<string> getListofVolumes(Shelves shelf)
        //{
        //    string url = string.Empty;
        //    if (shelf == Shelves.Recommendations)
        //        url = BookHelper.ConstructRecommendationsVolumesUrl();
        //    if (shelf == Shelves.Current)
        //        url = BookHelper.ConstructCurrentlyReviewingVolumesUrl();
        //    if (shelf == Shelves.Read)
        //        url = BookHelper.ConstructReadAndReviewedVolumesUrl();
        //    BookHelper.getDict(url);
        //    string temp;
        //    //dict.TryGetValue("items", out temp);
            
        //    return new List<string>();
        //}

        //public static int getNumberOfVolumes(Shelves shelf)
        //{
        //    int count = 0;
        //    string url = string.Empty;
        //    if (shelf == Shelves.Recommendations)
        //        url = BookHelper.ConstructRecommendationsShelfUrl();
        //    if (shelf == Shelves.Current)
        //        url = BookHelper.ConstructCurrentlyReviewingShelfUrl();
        //    if (shelf == Shelves.Read)
        //        url = BookHelper.ConstructHaveReadAndReviewedShelfUrl();

        //    BookHelper.getDict(url);

        //    //string temp;
        //    //value.TryGetValue("volumeCount", out temp);
        //    //int.TryParse(temp, out count);
        //    return count;
        //}
    }
}
