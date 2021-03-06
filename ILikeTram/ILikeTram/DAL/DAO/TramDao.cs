using System.Collections.Generic;
using System.Linq;
using ILikeTram.Model;
using Microsoft.EntityFrameworkCore;

namespace ILikeTram.DAL.DAO
{
    public class TramDao : IDao<Tram>
    {
        private DatabaseContext Context { get; set; }

        public TramDao(DatabaseContext context)
        {
            Context = context;
        }

        public void Add(Tram instance)
        {
            Context.Trams.Add(instance);
            Context.SaveChanges();
        }

        public void Delete(Tram instance)
        {
            Context.Trams.Remove(instance);
            Context.SaveChanges();
        }

        public Tram Read(string name)
        {
            return Context.Trams.AsNoTracking().Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Tram> ReadAll()
        {
            return Context.Trams.AsNoTracking().ToList();
        }

        public void Update(Tram instance)
        {
            Context.Trams.Update(instance);
            Context.SaveChanges();
        }
    }
}