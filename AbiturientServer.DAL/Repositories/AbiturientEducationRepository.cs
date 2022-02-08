using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientEducationRepository : EFCoreRepository<AbiturientEducation>
    {
        private DatabaseContext db;
        public AbiturientEducationRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
