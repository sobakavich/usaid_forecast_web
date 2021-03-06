﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CIAT.DAPA.USAID.Forecast.Data.Models
{
    /// <summary>
    /// This entity has the weather (historical average) climatic variables weather stations.
    /// </summary>
    public class Climatology
    {
        /// <summary>
        /// ID's climatology
        /// </summary>
        [BsonId]
        public ObjectId id { get; set; }
        /// <summary>
        /// Monthly data of the weather station
        /// </summary>
        public MonthlyDataStation monthly_data { get; set; }
    }
}
