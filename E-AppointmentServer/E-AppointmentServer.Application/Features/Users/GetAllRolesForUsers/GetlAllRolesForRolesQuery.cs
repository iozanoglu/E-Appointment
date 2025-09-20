using E_AppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Users.GetAllRolesForUsers;
public sealed record GetAllRolesForUsersQuery() : IRequest<Result<List<AppRole>>>;
