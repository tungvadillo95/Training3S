using AutoMapper;
using DDDExample.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDExample.Domain.Infrastructure.Handler.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = _mapper.Map<DDDExample.Infrastructure.Entities.User>(request);
                if (user != null)
                {
                    var roleId = await _dbContext.Roles.Where(r => r.Id == user.RoleId).FirstOrDefaultAsync();
                    if (roleId == null) return null;
                    await _dbContext.Users.AddAsync(user);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return user.Id.ToString();
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
