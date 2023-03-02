using DnDProject.Data;

namespace DnDProject.DataAccess
{
    public class BaseDataAccess
    {

        protected readonly Context DndDbContext;

        public BaseDataAccess(Context context) {
            DndDbContext = context;
        }
    }
}
