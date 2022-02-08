using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AbiturientRepository : EFCoreRepository<Abiturient>
    {
        private DatabaseContext db;
        public AbiturientRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
