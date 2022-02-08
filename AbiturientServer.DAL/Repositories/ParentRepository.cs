using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class ParentRepository : EFCoreRepository<Parent>
    {
        private DatabaseContext db;
        public ParentRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
