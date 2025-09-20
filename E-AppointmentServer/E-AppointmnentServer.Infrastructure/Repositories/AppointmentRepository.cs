using E_AppointmentServer.Domain.Entities;
using E_AppointmentServer.Domain.Repositories;
using E_AppointmnentServer.Infrastructure.Rename;
using GenericRepository;

namespace E_AppointmnentServer.Infrastructure.Repositories
{
    internal sealed class AppointmentRepository : Repository<Appointment, ApplicationDbContext>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
