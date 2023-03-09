using DnDApi.DataAccess.Data;
using DnDApi.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DnDApi.DataAccess.Source
{
    public class RaceDataAccess : BaseDataAccess
    {
        public RaceDataAccess(Context context) : base(context)
        {

        }

        public List<Race> List()
        {
            return DndDbContext.Races.ToList();
        }

        public Race Get(Guid id)
        {
            var model = DndDbContext.Races
                        .Include(a => a.SubRaces)
                        .Include(a => a.Features)
                            .FirstOrDefault(c => c.Id == id);

            if(model == null)
                throw new KeyNotFoundException();

            return model;
        }

        public Race Insert(Race model)
        {
            DndDbContext.Races.Add(model);

            return model;
        }

        public void Update(Class model)
        {
            DndDbContext.Attach(model);

            DndDbContext.Entry(model).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            var model = DndDbContext.Races.Find(id);

            if(model != null) {
                DndDbContext.Races.Remove(model);
            }
        }
    }
}
