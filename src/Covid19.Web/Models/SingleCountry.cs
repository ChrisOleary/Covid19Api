using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Api.Models
{
    public class SingleCountry
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }

        public int NewDeaths { get; set; }

        //[DisplayFormat(DataFormatString = "{0:N0}")]
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy hh:mm}")]
        public DateTime Date { get; set; } 
    }
}
