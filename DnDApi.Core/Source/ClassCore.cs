using DnDApi.DataAccess.Data;
using DnDApi.DataAccess.Source;
using DnDApi.Shared.DTOs;

namespace DnDApi.Core.Source
{
    public class ClassCore : BaseCore
    {
        private ClassDataAccess ClassDataAccess { get; }

        public ClassCore(Context context, ClassDataAccess classDataAccess) : base(context) {
            ClassDataAccess = classDataAccess;
        }


        public List<Class> List() {
            return ClassDataAccess.List();
        }

        public Class Get(Guid id) {
            return ClassDataAccess.Get(id);
        }

        public Class Insert(Class model) {
            ClassDataAccess.Insert(model);

            DndDbContext.SaveChangesAsync();

            return model;
        }

        public void Update(Class model) {

            ClassDataAccess.Update(model);

            DndDbContext.SaveChangesAsync();
        }

        public void Delete(Guid id) {
                ClassDataAccess.Delete(id);


                DndDbContext.SaveChangesAsync();
        }
    }
}
