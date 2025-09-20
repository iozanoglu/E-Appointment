using E_AppointmentServer.Domain.Entities;

namespace E_AppointmentServer.Application.Services
{
    public interface IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user);
    }
}
