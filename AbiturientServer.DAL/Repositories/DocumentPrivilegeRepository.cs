using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentPrivilegeRepository : EFCoreRepository<DocumentPrivilege>
    {
        private DatabaseContext db;
        public DocumentPrivilegeRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
