using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Domains
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string imdbID { get; set; }
        public string listingType { get; set; }
        public string imdbRating { get; set; }
        public string Poster { get; set; }
        public string Location { get; set; }
        public string Language { get; set; }
        public string Plot { get; set; }
        public List<string> Stills { get; set; }
        public List<string> SoundEffects { get; set; }

    }
}
