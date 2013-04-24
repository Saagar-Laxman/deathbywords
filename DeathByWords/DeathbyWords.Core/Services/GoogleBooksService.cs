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

        /// <summary>
        /// Gets a shelf from Google and then return the list of books in the recommendations shelf.
        /// </summary>
        /// <returns>List of books on the requested shelf</returns>
        public static List<Book> getRecommendations()
        {
            string url = BookHelper.ConstructRecommendationsVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }


        /// <summary>
        /// Gets a shelf from Google and then return the list of books in the Reading shelf.
        /// </summary>
        /// <returns>List of books on the requested shelf</returns>
        public static List<Book> getCurrent()
        {
            string url = BookHelper.ConstructCurrentlyReviewingVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }


        /// <summary>
        /// Gets a shelf from Google and then return the list of books in the Read shelf.
        /// </summary>
        /// <returns>List of books on the requested shelf</returns>
        public static List<Book> getRead()
        {
            string url = BookHelper.ConstructReadAndReviewedVolumesUrl();
            Shelf shelf = BookHelper.GetShelf(url);
            return shelf.items;
        }
    }
}
