using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class SpecialtyExamRepository : EFCoreRepository<SpecialtyExam>
    {
        private DatabaseContext db;
        public SpecialtyExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
