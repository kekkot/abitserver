using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentPersonalRepository : EFCoreRepository<DocumentPersonal>
    {
        private DatabaseContext db;
        public DocumentPersonalRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
