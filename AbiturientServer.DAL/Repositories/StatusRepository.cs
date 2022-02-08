using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class StatusRepository : EFCoreRepository<Status>
    {
        private DatabaseContext db;
        public StatusRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
