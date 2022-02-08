using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class SpecialtyDetailRepository : EFCoreRepository<SpecialtyDetail>
    {
        private DatabaseContext db;
        public SpecialtyDetailRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
