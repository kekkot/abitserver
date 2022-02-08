using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class RegionRepository : EFCoreRepository<Region>
    {
        private DatabaseContext db;
        public RegionRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
