using DnDApi.DataAccess.Data;

namespace DnDApi.DataAccess
{
    public class BaseDataAccess
    {

        protected readonly Context DndDbContext;

        public BaseDataAccess(Context context) {
            DndDbContext = context;
        }
    }
}
