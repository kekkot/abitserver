using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class EducationalInstitutionRepository : EFCoreRepository<EducationalInstitution>
    {
        private DatabaseContext db;
        public EducationalInstitutionRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
