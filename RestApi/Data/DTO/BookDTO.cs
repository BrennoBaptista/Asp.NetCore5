using RestApi.Hypermedia;
using RestApi.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestApi.Data.DTO
{
    public class BookDTO : ISupportHyperMedia
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
