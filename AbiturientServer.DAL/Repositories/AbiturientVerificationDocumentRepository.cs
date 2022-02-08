using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientVerificationDocumentRepository : EFCoreRepository<AbiturientVerificationDocument>
    {
        private DatabaseContext db;
        public AbiturientVerificationDocumentRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
