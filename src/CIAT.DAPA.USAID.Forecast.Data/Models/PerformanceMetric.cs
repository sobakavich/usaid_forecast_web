﻿using CIAT.DAPA.USAID.Forecast.Data.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIAT.DAPA.USAID.Forecast.Data.Models
{
    /// <summary>
    /// This entity represents an indicator of behavior prediction models
    /// </summary>
    public class PerformanceMetric
    {
        /// <summary>
        /// Metric name
        /// </summary>
        [BsonRepresentation(BsonType.String)]
        public MeasurePerformance name { get; set; }
        /// <summary>
        /// Metric value
        /// </summary>
        public double value { get; set; }
    }
}
