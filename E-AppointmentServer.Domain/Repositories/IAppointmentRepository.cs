﻿using E_AppointmentServer.Domain.Entities;
using GenericRepository;

namespace E_AppointmentServer.Domain.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
    }
}
