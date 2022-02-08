using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class SpecialtyContestRepository : EFCoreRepository<SpecialtyContest>
    {
        private DatabaseContext db;
        public SpecialtyContestRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
