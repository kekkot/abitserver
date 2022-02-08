using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class AddressRepository : EFCoreRepository<Address>
    {
        private DatabaseContext db;
        public AddressRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
