using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class IndividualAchievementRepository : EFCoreRepository<IndividualAchievement>
    {
        private DatabaseContext db;
        public IndividualAchievementRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
