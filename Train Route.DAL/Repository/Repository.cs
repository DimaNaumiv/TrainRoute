using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS;
using Models;

namespace Train_Route.DAL.Repository
{
    public class Repository
    {
        private AppDbContext _db;
        public Repository()
        {
            _db = new AppDbContext();
        }

        public List<Routes> GatRotesAll()
        {
            return _db.Routes.ToList();
        }
        public List<Routes> GetRotesFromTo(int From , int To)
        {
            return _db.Routes.Include(r => r.Sations)          
            .ThenInclude(rs => rs.Station).Where(r =>
            r.Sations.Any(rs => rs.Station.Code == From) &&
            r.Sations.Any(rs => rs.Station.Code == To) &&
            r.Sations.First(rs => rs.Station.Code == From).StationOrder <
            r.Sations.First(rs => rs.Station.Code == To).StationOrder)
            .ToList();
        }

        public List<Routes[]> GetRotesFromToOneStep(int From, int To)
        {
            List<Routes> FromList = _db.Routes.Include(r=>r.Sations)
                .ThenInclude(rs => rs.Station)
                .Where(r=> r.Sations.Any(rs=>rs.Station.Code == From)).ToList();
            List<Routes> ToList = _db.Routes.Include(r => r.Sations)
                .ThenInclude(rs => rs.Station)
                .Where(r => r.Sations.Any(rs => rs.Station.Code == To)).ToList();
            
            int FromIndex = 0;
            int ToIndex = 0;

            List<List<InterData>> data = new List<List<InterData>>();

            List<Routes[]> routes = new List<Routes[]>();
            foreach (var i in FromList)
            {
                List<InterData> tempData = new List<InterData>();
                var StationsFrom = i.Sations.Select(s => s.Station.Code).ToHashSet();
                foreach (var j in ToList)
                {
                    var StationsTo = j.Sations.Select(s=>s.Station.Code).ToHashSet();
                    var inter = StationsFrom.Intersect(StationsTo).ToList();
                    if (inter.Count != 0)
                    {
                        tempData.Add(new InterData() { Values = inter, Indexs = [FromIndex, ToIndex] });
                    }
                    ToIndex++;
                }
                if (tempData.Count > 0)
                {
                    data.Add(new List<InterData>(tempData));
                }
                FromIndex++;
                ToIndex = 0;
            }
            foreach (var group in data)
            {
                foreach (var item in group)
                {
                    Routes[] rout = new Routes[2];
                    rout[0] = FromList[item.Indexs[0]];
                    rout[1] = ToList[item.Indexs[1]];
                    routes.Add(rout);
                }
            }
            return routes;
        }

    }
}
