using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class SpecialtyRepository : EFCoreRepository<Specialty>
    {
        private DatabaseContext db;
        public SpecialtyRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}