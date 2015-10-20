using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ForecastController : ApiController
    {
        public CityForecast[] Get(String lieu = null)
        {

            return GetForecastFromDatabase().OrderBy(forecast => forecast.City).ToArray();

            //return new CityForecast[]
            //{
            //        new CityForecast()
            //        {
            //            City = "Namur", Description = "Il fait chaud", MaxTemperature = 30
            //        },
            //        new CityForecast()
            //        {
            //            City = "Mouscron", Description = "Pas chaud", MaxTemperature = 10
            //        }
            //}.OrderBy(forecast => forecast.City).ToArray();

            //if (lieu == "Namur")
            //{
            //    return new String[]
            //    {
            //    "Soleil", "Chaud"
            //    };
            //} else
            //{
            //    return new String[]
            //    {
            //    "Pluie", "Froid"
            //    };
            //}
        }

        private CityForecast[] GetForecastFromDatabase()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLocalDb; Initial Catalog = WeatherForecast; Integrated Security = True; Pooling = False");
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", connection);

            SqlDataReader reader = cmd.ExecuteReader();

            List<CityForecast> forecasts = new List<CityForecast>();

            while(reader.Read())
            {
                CityForecast forecast = new CityForecast();
                forecast.City = (String) reader["City"];
                forecast.Description = (String) reader["Description"];
                forecast.MaxTemperature = (decimal) reader["MaxTemperature"];
                forecasts.Add(forecast);
            }

            reader.Close();
            connection.Close();
            return forecasts.ToArray();
        }

    }
}
