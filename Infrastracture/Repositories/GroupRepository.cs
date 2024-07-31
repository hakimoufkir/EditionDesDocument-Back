using Application.IRepository;
using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Repositories
{
    public class GroupRepository  : GenericRepository<Group> ,IGroupRepository
    {
        private readonly ApplicationDbContext _context;

        public GroupRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    
    }
}
