using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using DeathbyWords.Services.Models;
using Newtonsoft.Json;

namespace DeathByWords.Core.Models
{
    [DataContract]
    public class Book
    {
        [DataMember (Name="volumeInfo")]
        private BookInfo _info { get; set; }

        [DataMember (Name="id")]
        public string Id { get; set; }
        
        public string Title { get { return _info.Title; }  }
        public string Description { get { return _info.Description; } }
        
        public string ImageURL
        {
            get
            {
                string url = string.Empty;
                if (_info.ImageLinks != null)
                {
                    if (_info.ImageLinks.ContainsKey("thumbnail"))
                        url = _info.ImageLinks["thumbnail"];
                    else if (_info.ImageLinks.ContainsKey("smallThumbnail"))
                        url = _info.ImageLinks["smallThumbnail"];
                }
                return url;
            }
        }
        
        public string Authors
        {
            get
            {
                string authors = string.Empty;
                foreach (var author in _info.Authors)
                {
                    authors += author + ",";
                }
                return authors;
            }
        }


        /// <summary>
        /// Private class to assist with parsing JSON
        /// </summary>
        private class BookInfo
        {

            [DataMember(Name = "title")]
            public string Title { get; set; }
            [DataMember(Name = "description")]
            public string Description { get; set; }
            [DataMember(Name = "imageLinks")]
            public Dictionary<string, string> ImageLinks { get; set; }
            [DataMember(Name = "authors")]
            public string[] Authors { get; set; }
        }
    }
}