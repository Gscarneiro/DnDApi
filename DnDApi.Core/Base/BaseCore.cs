using DnDApi.DataAccess.Data;

namespace DnDApi.Core
{
    public class BaseCore
    {
        protected readonly Context DndDbContext;

        public BaseCore(Context context) {
            DndDbContext = context;
        }
    }
}
