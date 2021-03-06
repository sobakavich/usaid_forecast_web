﻿using System;

namespace CIAT.DAPA.USAID.Forecast.Data.Enums
{
    /// <summary>
    /// This enumeration represents the entities that are affected in the system
    /// </summary>
    public enum LogEntity
    {
        /// <summary>
        /// States' table
        /// </summary>
        lc_state,
        /// <summary>
        /// Municipalities' table
        /// </summary>
        lc_municipality,
        /// <summary>
        /// Weather stations' table
        /// </summary>
        lc_weather_station,
        /// <summary>
        /// Crops' table
        /// </summary>
        cp_crop,
        /// <summary>
        /// Soils' table
        /// </summary>
        cp_soil,
        /// <summary>
        /// Cultivars' table
        /// </summary>
        cp_cultivar,
        /// <summary>
        /// Administrative log table
        /// </summary>
        log_administrative,
        /// <summary>
        /// Service log table
        /// </summary>
        log_service,
        /// <summary>
        /// Table of climatology
        /// </summary>
        hs_climatology,
        /// <summary>
        /// Climate History table
        /// </summary>
        hs_historical_climatic,
        /// <summary>
        /// Yield history table
        /// </summary>
        hs_historical_yield,
        /// <summary>
        /// Yield history table
        /// </summary>
        fs_forecast,
        /// <summary>
        /// Forecast scenario table
        /// </summary>
        fs_forecast_scenario,
        /// <summary>
        /// Yield forecast table
        /// </summary>
        fs_forecast_yield,
        /// <summary>
        /// Climate forecast table
        /// </summary>
        fs_forecast_climate

    }
}
