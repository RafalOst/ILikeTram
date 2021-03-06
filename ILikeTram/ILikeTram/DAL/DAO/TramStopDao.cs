using System.Collections.Generic;
using System.Linq;
using ILikeTram.Model;
using Microsoft.EntityFrameworkCore;

namespace ILikeTram.DAL.DAO
{
    public class TramStopDao : IDao<TramStop>
    {
        private DatabaseContext Context { get; set; }

        public TramStopDao(DatabaseContext context)
        {
            Context = context;
        }

        public void Add(TramStop instance)
        {
            Context.TramStops.Add(instance);
            Context.SaveChanges();
        }

        public void Delete(TramStop instance)
        {
            Context.TramStops.Remove(instance);
            Context.SaveChanges();
        }

        public TramStop Read(string name)
        {
            return Context.TramStops.AsNoTracking().Where(x => x.Name == name).FirstOrDefault();
        }

        public List<TramStop> ReadAll()
        {
            return Context.TramStops.AsNoTracking().ToList();
        }

        public void Update(TramStop instance)
        {
            Context.TramStops.Update(instance);
            Context.SaveChanges();
        }
    }
}
