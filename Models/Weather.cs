using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAPI.Models
{

 public class WeatherObject
  {
    /// <summary>
    /// String representing the City Name
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// List containing the weather array
    /// </summary>
    public IList<weather> weather { get; set; }

    /// <summary>
    /// object containing the main weather attributes
    /// </summary>
    public main  main { get; set; }

    /// <summary>
    /// object containing the wind attributes
    /// </summary>
    public wind  wind { get; set; }

    }
    public class weather{
            public string main { get; set; }
            public string description { get; set; }

    }

    public class main{
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }

    }
    public class wind{
        public double speed { get; set; }
        public double gust { get; set; }

    }
}