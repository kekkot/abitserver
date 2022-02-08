using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;
namespace AbiturientServer.DAL.Repositories
{
    public class EducationLevelRepository : EFCoreRepository<EducationLevel>
    {
        private DatabaseContext db;
        public EducationLevelRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
