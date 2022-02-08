using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentEducationRepository : EFCoreRepository<DocumentEducation>
    {
        private DatabaseContext db;
        public DocumentEducationRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}

