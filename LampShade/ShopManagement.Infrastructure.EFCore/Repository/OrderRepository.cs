using _0_Framework.Infrastructure;
using ShopManagement.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public interface OrderRepository : RepositoryBase<long, Order>, IOrderRepository
    {
    }
}
