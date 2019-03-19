using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartLearning.Data.Repository.IServices;
using SmartLearning.Data.Repository.Services;
using SmartLearning.Server.Db; 

namespace SmartLearning.Data.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services,string connectionString)
        {
            services.AddDbContext<SmartDbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<ISessionRepository, SessionRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IClassRepository, ClassRepository>();
            services.AddTransient<IExaminationRepository, ExaminationRepository>();
            services.AddTransient<ITimeTableRepository, TimeTableRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IEnrollmentRepository, EnrollmentRepository>();
        }
    }
}
