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
        
        public string Title { get { return _info.title; }  }
        public string Description { get { return _info.description; } }
        
        public string ImageURL
        {
            get
            {
                string url = string.Empty;
                if (_info.imageLinks != null)
                {
                    if (_info.imageLinks.ContainsKey("thumbnail"))
                        url = _info.imageLinks["thumbnail"];
                    else if (_info.imageLinks.ContainsKey("smallThumbnail"))
                        url = _info.imageLinks["smallThumbnail"];
                }
                return url;
            }
        }
        
        public string Authors
        {
            get
            {
                string authors = string.Empty;
                foreach (var author in _info.authors)
                {
                    authors += author + ",";
                }
                return authors;
            }
        }



        private class BookInfo
        {

            //TODO - Cleanup with Datamember
            public string title { get; set; }
            public string description { get; set; }
            public Dictionary<string, string> imageLinks { get; set; }
            public string[] authors { get; set; }
        }
    }
}