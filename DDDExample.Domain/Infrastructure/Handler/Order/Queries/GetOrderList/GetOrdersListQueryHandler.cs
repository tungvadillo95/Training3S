using AutoMapper;
using DDDExample.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDExample.Domain.Infrastructure.Handler.Order.Queries.GetOrderList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, IEnumerable<DDDExample.Infrastructure.Entities.Order>>
    {
        private readonly IDDDExampleDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(IDDDExampleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DDDExample.Infrastructure.Entities.Order>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            var orders = await _dbContext.Orders.Include(o => o.User).ThenInclude(u => u.Role)
                                                .AsNoTracking()
                                          .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                                          .ToListAsync();
            if (orders.Count > 0) return orders;
            return new List<DDDExample.Infrastructure.Entities.Order>();
        }
    }
}
