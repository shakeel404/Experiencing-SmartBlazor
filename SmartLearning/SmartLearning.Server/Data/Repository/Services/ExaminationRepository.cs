using SmartLearning.Data.Repository.IServices;
using SchooSmartLearningl.Data.Repository;
using SmartLearning.Shared.Models;
using SmartLearning.Server.Db;

namespace SmartLearning.Data.Repository.Services
{
    public class ExaminationRepository : Repository<Examination>, IExaminationRepository
    {
        public ExaminationRepository(SmartDbContext dbContext):base(dbContext)
        {

        }
    }
}
