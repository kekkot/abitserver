using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class FormOfEducationRepository : EFCoreRepository<FormOfEducation>
    {
        private DatabaseContext db;
        public FormOfEducationRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
