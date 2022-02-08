using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentApprovalRepository : EFCoreRepository<DocumentApproval>
    {
        private DatabaseContext db;
        public DocumentApprovalRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
