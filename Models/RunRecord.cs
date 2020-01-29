using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bogoodski2020backend.Models
{
    public class RunRecord
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Key")]
        public decimal Key { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }

        [BsonElement("Duration")]
        public decimal Duration { get; set; }

        [BsonElement("Distance")]
        public decimal Distance { get; set; }

        [BsonElement("Comment")]
        public string Comment { get; set; }
    }
}
