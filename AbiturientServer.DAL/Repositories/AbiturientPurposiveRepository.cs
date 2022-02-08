using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientPurposiveRepository : EFCoreRepository<AbiturientPurposive>
    {
        private DatabaseContext db;
        public AbiturientPurposiveRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
