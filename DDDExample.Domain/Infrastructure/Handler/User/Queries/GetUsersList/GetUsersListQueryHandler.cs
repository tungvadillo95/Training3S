using AutoMapper;
using DDDExample.Domain.DTOs.Respone.User;
using DDDExample.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDExample.Domain.Infrastructure.Handler.User.Queries.GetUsersList
{
    class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, IEnumerable<UserDetail>>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUsersListQueryHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDetail>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var users = await _dbContext.Users.Include(u => u.Role).ToListAsync();
            if(users.Count > 0)
            {
                var usersDto = _mapper.Map<List<UserDetail>>(users);
                return usersDto;
            }
            return new List<UserDetail>();
        }
    }
}
