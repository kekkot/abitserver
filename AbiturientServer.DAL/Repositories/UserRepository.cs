using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class UserRepository : EFCoreRepository<User>
    {
        private DatabaseContext db;
        public UserRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
