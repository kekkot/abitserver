using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class EnrollRepository : EFCoreRepository<Enroll>
    {
        private DatabaseContext db;
        public EnrollRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}