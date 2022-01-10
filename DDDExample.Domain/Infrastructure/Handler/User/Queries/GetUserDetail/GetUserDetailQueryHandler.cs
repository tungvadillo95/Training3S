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

namespace DDDExample.Domain.Infrastructure.Handler.User.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetail>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<UserDetail> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            Guid guidId;
            if (!Guid.TryParse(request.Id, out guidId)) return null;
            var user =  await _dbContext.Users.Where(u => u.Id == guidId)
                                                .Include(u => u.Role)
                                                .FirstOrDefaultAsync();
            if (user != null)
            {
                var userDto = _mapper.Map<UserDetail>(user);
                return userDto;
            }

            return null;
        }
    }
}
