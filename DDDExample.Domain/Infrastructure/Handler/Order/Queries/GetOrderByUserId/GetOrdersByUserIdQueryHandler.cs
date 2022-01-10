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

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderByUserId
{
    public class GetOrdersByUserIdQueryHandler : IRequestHandler<GetOrdersByUserIdQuery, IEnumerable<DDDExample.Infrastructure.Entities.Order>>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrdersByUserIdQueryHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DDDExample.Infrastructure.Entities.Order>> Handle(GetOrdersByUserIdQuery request, CancellationToken cancellationToken)
        {
            var orders = await _dbContext.Orders.Where(o => o.UserId == request.UserId)
                                              .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                                              .ToListAsync();
            if (orders.Count > 0) return orders;
            return new List<DDDExample.Infrastructure.Entities.Order>();
        }
    }
}
