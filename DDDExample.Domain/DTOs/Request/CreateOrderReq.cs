using DDDExample.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.DTOs.Request
{
    public class CreateOrderReq
    {
        public Guid UserId { get; set; }
        public string ProductIds { get; set; }
        public ICollection<OrderDetail> OrderDetails => GetOrder();
        private List<OrderDetail> GetOrder()
        {
            var result = new List<OrderDetail>();
            var listProductId = ProductIds.Split(",");
            if (listProductId.Length < 1) return result;
            foreach (var item in listProductId)
            {
                Guid productId;
                if (!Guid.TryParse(item, out productId)) return new List<OrderDetail>();
                var orderdetail = new OrderDetail()
                {
                    ProductId = productId
                };
                result.Add(orderdetail);
            }
            return result;
        }
    }
}
