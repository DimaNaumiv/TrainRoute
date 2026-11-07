using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_Route.DAL.Repository;

namespace Train_Route
{
    public class Servise
    {
        private Repository _rep;
        public Servise() {
            _rep = new Repository();
        }

        public List<Routes> GetFromTo(int From , int To)
        {
            return _rep.GetRotesFromTo(From, To);
        }
        public List<Routes[]> GetFromToOneStep(int From, int To)
        {
            return _rep.GetRotesFromToOneStep(From, To);
        }
        //public List<Routes> GetRotesByCode (int code)
        //{
        //    return _rep.GetRouteByCode(code);
        //}

    }
}
