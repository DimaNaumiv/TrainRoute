using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Route
{
    public class Routes
    {
        public Guid Id {  get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }
        public List<RouteStation> Sations { get; set; }

    }
}
