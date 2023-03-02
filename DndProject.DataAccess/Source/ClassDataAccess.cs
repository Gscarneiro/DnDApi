using DnDProject.Data;
using DnDProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDProject.DataAccess
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

        public void Update(Class model) {

            DndDbContext.Entry(model).State = EntityState.Modified;

            DndDbContext.Classes.Update(model);

            DndDbContext.SaveChangesAsync();
        }


        public Class Insert(Class model) {
            DndDbContext.Classes.Add(model);

            DndDbContext.SaveChangesAsync();

            return model;
        }

        public void Delete(Guid id) {
            var model = DndDbContext.Classes.Find(id);

            if (model != null) {
                DndDbContext.Classes.Remove(model);
                DndDbContext.SaveChangesAsync();
            }
        }
    }
}
