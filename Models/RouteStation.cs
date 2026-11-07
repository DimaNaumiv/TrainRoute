using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Route
{
    public class RouteStation
    {
        public Guid Id { get; set; }
        public Guid StationId { get; set; }
        public int StationOrder { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartTime { get; set; }
        public Guid RoutesId { get; set; }
        public Routes Routes { get; set; }
        public Station Station { get; set; }

    }
}
