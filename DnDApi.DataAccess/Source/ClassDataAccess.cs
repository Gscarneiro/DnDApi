using DnDApi.DataAccess.Data;
using DnDApi.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DnDApi.DataAccess.Source
{
    public class ClassDataAccess : BaseDataAccess
    {
        public ClassDataAccess(Context context) : base(context)
        {

        }

        public List<Class> List()
        {
            return DndDbContext.Classes.ToList();
        }

        public Class Get(Guid id)
        {
            var model = DndDbContext.Classes.Include(a => a.SubClasses).Include(a => a.Features).FirstOrDefault(c => c.Id == id);
            
            if (model == null)
                throw new KeyNotFoundException();
            
            return model;
        }

        public Class Insert(Class model)
        {
            DndDbContext.Classes.Add(model);

            return model;
        }

        public void Update(Class model)
        {
            DndDbContext.Attach(model);

            DndDbContext.Entry(model).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            var model = DndDbContext.Classes.FirstOrDefault(c => c.Id == id);

            if(model != null) {
                DndDbContext.Classes.Remove(model);
            }
        }
    }
}
