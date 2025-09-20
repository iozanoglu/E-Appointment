using E_AppointmentServer.Domain.Entities;
using E_AppointmentServer.Domain.Repositories;
using E_AppointmnentServer.Infrastructure.Rename;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories;
internal sealed class UserRoleRepository : Repository<AppUserRole, ApplicationDbContext>, IUserRoleRepository
{
    public UserRoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}