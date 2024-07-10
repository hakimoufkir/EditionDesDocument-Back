﻿using Application.IRepository;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastracture.Repositories
{
    internal class RequestRepository : GenericRepository<Requests>, IRequestRepository
    {
        public RequestRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}