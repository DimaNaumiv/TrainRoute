using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_Route;

namespace Models
{
    public class Station
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<RouteStation> RouteStations { get; set; }
    }
}
