using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class LanguageRepository : EFCoreRepository<Language>
    {
        private DatabaseContext db;
        public LanguageRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
