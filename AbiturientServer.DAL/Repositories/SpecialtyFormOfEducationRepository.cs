using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class SpecialtyFormOfEducationRepository : EFCoreRepository<SpecialtyFormOfEducation>
    {
        private DatabaseContext db;
        public SpecialtyFormOfEducationRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
