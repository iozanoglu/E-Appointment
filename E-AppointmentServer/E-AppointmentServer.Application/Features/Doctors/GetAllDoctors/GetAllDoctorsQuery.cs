using E_AppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace E_AppointmentServer.Application.Features.Doctors.GetAllDoctor
{
    public sealed record GetAllDoctorsQuery(): IRequest<Result<List<Doctor>>> ; 
}
