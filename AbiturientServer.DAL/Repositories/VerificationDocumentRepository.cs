using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class VerificationDocumentRepository : EFCoreRepository<VerificationDocument>
    {
        private DatabaseContext db;
        public VerificationDocumentRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
