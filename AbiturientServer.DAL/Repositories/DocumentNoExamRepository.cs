using AbiturientServer.DAL.Abstractions;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;

namespace AbiturientServer.DAL.Repositories
{
    public class DocumentNoExamRepository : EFCoreRepository<DocumentNoExam>
    {
        private DatabaseContext db;
        public DocumentNoExamRepository(DatabaseContext db) : base(db)
        {
            this.db = db;
        }
    }
}
