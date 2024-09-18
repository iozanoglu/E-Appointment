using E_AppointmentServer.Domain.Entities;
using E_AppointmentServer.Domain.Repositories;
using E_AppointmnentServer.Infrastructure.Rename;
using GenericRepository;

namespace E_AppointmnentServer.Infrastructure.Repositories
{
    internal sealed class PatientRepository : Repository<Patient, ApplicationDbContext>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
