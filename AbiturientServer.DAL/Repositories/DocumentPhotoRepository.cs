using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentPhotoRepository : EFCoreRepository<DocumentPhoto>
    {
        private DatabaseContext db;
        public DocumentPhotoRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
