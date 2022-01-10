using DDDExample.Domain.DTOs.Respone.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.User.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<IEnumerable<UserDetail>>
    {
    }
}
