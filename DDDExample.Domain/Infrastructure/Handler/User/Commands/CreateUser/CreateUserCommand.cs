using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.User.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
    }
}
