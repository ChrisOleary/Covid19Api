using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Api.Models
{
    public class ApiRootObject
    {
        public Global Global { get; set; }
        public List<SingleCountry> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
