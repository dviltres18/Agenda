﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Agenda.Authorization.Roles;
using Agenda.Authorization.Users;
using Agenda.MultiTenancy;

namespace Agenda.EntityFrameworkCore
{
    public class AgendaDbContext : AbpZeroDbContext<Tenant, Role, User, AgendaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
            : base(options)
        {
        }
    }
}