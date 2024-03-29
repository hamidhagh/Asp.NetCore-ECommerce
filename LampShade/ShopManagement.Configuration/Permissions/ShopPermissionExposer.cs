﻿using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
        {
            {
                "Product", new List<PermissionDto>
                {
                    new(ShopPermissions.ListProducts, "ListProducts"),
                    new(ShopPermissions.SearchProducts, "SearchProducts"),
                    new(ShopPermissions.CreateProduct, "CreateProduct"),
                    new(ShopPermissions.EditProduct, "EditProduct")
                }
            },
            {
                "ProductCategory", new List<PermissionDto>
                {
                    new(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                    new(ShopPermissions.ListProductCategories, "ListProductCategories"),
                    new(ShopPermissions.CreateProductCategory, "CreateProductCategory"),
                    new(ShopPermissions.EditProductCategory, "EditProductCategory")
                }
            }
        };
        }
    }
}
