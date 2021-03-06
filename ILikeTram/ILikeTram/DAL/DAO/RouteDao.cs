using System.Collections.Generic;
using System.Linq;
using ILikeTram.Model;
using Microsoft.EntityFrameworkCore;

namespace ILikeTram.DAL.DAO
{
    public class RouteDao : IDao<Route>
    {
        private DatabaseContext Context { get; set; }

        public RouteDao(DatabaseContext context)
        {
            Context = context;
        }

        public void Add(Route instance)
        {
            Context.TramRoutes.Add(instance);
            Context.SaveChanges();
        }

        public void Delete(Route instance)
        {
            Context.TramRoutes.Remove(instance);
            Context.SaveChanges();
        }

        public Route Read(string name)
        {
            return Context.TramRoutes.AsNoTracking().Include(t => t.StopsList).Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Route> ReadAll()
        {
            return Context.TramRoutes.AsNoTracking().Include(t => t.StopsList).ToList();
        }

        public void Update(Route instance)
        {
            Context.TramRoutes.Update(instance);
            Context.SaveChanges();
        }
    }
}
