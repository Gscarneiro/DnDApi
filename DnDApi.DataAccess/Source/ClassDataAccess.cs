using DnDApi.DataAccess.Data;
using DnDApi.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DnDApi.DataAccess.Source
{
    public class ClassDataAccess : BaseDataAccess
    {
        public ClassDataAccess(Context context) : base(context) {

        }

        public List<Class> List() {
            return DndDbContext.Classes.ToList();
        }

        public Class Get(Guid id) {
            return DndDbContext.Classes.Find(id);
        }

        public Class Insert(Class model) {
            DndDbContext.Classes.Add(model);

            return model;
        }

        public void Update(Class model) {

            DndDbContext.Entry(model).State = EntityState.Modified;

            DndDbContext.Classes.Update(model);
        }

        public void Delete(Guid id) {
            var model = DndDbContext.Classes.Find(id);

            if (model != null) {
                DndDbContext.Classes.Remove(model);
            }
        }
    }
}
