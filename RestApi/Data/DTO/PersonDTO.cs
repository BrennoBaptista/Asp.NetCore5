using RestApi.Hypermedia;
using RestApi.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestApi.Data.DTO
{
    public class PersonDTO : ISupportHyperMedia
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
