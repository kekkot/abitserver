using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class EducationalDocumentRepository : EFCoreRepository<EducationalDocument>
    {
        private DatabaseContext db;
        public EducationalDocumentRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
