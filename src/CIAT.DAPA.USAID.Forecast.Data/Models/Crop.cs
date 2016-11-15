﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace CIAT.DAPA.USAID.Forecast.Data.Models
{
    /// <summary>
    /// This entity has the information about crops
    /// </summary>
    public class Crop
    {
        /// <summary>
        /// ID's crop
        /// </summary>
        [BsonId]
        public ObjectId id { get; set; }
        /// <summary>
        /// Crops' name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Shows the trace of the changes that occurred in the entity
        /// </summary>
        public Track track { get; set; }
        /// <summary>
        /// Array of configuration files
        /// </summary>
        public IEnumerable<ConfigurationFile> conf_files { get; set; }
        /// <summary>
        /// Shows the trace of the changes that occurred in the entity
        /// </summary>
        public IEnumerable<Setup> setup{ get; set; }
    }
}