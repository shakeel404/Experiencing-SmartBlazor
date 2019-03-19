using SmartLearning.Data.Repository.IServices;
using SchooSmartLearningl.Data.Repository;
using SmartLearning.Shared.Models;
using SmartLearning.Server.Db;

namespace SmartLearning.Data.Repository.Services
{
    public class EnrollmentRepository :Repository<Enrollment>,IEnrollmentRepository
    {
        public EnrollmentRepository(SmartDbContext context):base(context)
        {

        }
    }
}
