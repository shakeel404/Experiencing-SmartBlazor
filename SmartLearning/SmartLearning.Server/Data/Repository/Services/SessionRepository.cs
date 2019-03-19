using SmartLearning.Data.Repository.IServices;
using SchooSmartLearningl.Data.Repository;
using SmartLearning.Shared.Models;
using SmartLearning.Server.Db;

namespace SmartLearning.Data.Repository.Services
{
    public class SessionRepository :Repository<Session>,ISessionRepository
    {
        public SessionRepository(SmartDbContext dbContext):base(dbContext)
        {
            
        }
       
    }
}
