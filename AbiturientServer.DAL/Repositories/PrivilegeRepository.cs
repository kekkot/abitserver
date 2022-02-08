using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class PrivilegeRepository : EFCoreRepository<Privilege>
    {
        private DatabaseContext db;
        public PrivilegeRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
