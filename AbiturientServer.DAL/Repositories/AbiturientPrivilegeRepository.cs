using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientPrivilegeRepository : EFCoreRepository<AbiturientPrivilege>
    {
        private DatabaseContext db;
        public AbiturientPrivilegeRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
