using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class EditProductPicture : CreateProductPicture
    {
        public long Id { get; set; }
    }
}
