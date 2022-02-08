using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentAchievementRepository : EFCoreRepository<DocumentAchievement>
    {
        private DatabaseContext db;
        public DocumentAchievementRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
