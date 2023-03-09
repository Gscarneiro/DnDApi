using DnDApi.DataAccess.Data;
using DnDApi.DataAccess.Source;
using DnDApi.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApi.Core.Source
{
    public class RaceCore : BaseCore
    {
        private RaceDataAccess RaceDataAccess { get; }

        public RaceCore(Context context, RaceDataAccess raceDataAccess) : base(context)
        {
            RaceDataAccess = raceDataAccess;
        }

        public List<Race> List()
        {
            return RaceDataAccess.List();
        }

        public Race Get(Guid id)
        {
            return RaceDataAccess.Get(id);
        }

        public Race Insert(Race model)
        {
            model.Id = new Guid();

            RaceDataAccess.Insert(model);

            DndDbContext.SaveChangesAsync();

            return model;
        }

        public void Update(Race model)
        {
            RaceDataAccess.Update(model);

            DndDbContext.SaveChangesAsync();
        }

        public void Delete(Guid id)
        {
            RaceDataAccess.Delete(id);

            DndDbContext.SaveChangesAsync();
        }
    }
}
