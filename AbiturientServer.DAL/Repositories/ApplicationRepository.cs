using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ApplicationRepository : EFCoreRepository<Application>
    {
        private DatabaseContext db;
        public ApplicationRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
