using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class CountryRepository : EFCoreRepository<Country>
    {
        private DatabaseContext db;
        public CountryRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
