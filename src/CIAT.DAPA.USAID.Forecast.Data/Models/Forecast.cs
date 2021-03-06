﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CIAT.DAPA.USAID.Forecast.Data.Models
{
    public class Forecast
    {
        /// <summary>
        /// ID's prediction process
        /// </summary>
        [BsonId]
        public ObjectId id { get; set; }
        /// <summary>
        /// Start date of the process
        /// </summary>
        public DateTime start { get; set; }
        /// <summary>
        /// End date of the process
        /// </summary>
        public DateTime end { get; set; }
        /// <summary>
        /// Level of confidence for the generation of the intervals
        /// </summary>
        public double confidence { get; set; }
        /// <summary>
        /// Shows the trace of the changes that occurred in the entity
        /// </summary>
        public Track track { get; set; }
    }
}
