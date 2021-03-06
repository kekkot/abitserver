using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientIndividualAchievementRepository : EFCoreRepository<AbiturientIndividualAchievement>
    {
        private DatabaseContext db;
        public AbiturientIndividualAchievementRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
