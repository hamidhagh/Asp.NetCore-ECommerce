﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampshadeQuery.Contracts.Inventory
{
    public class IsInStock
    {
        public int Count { get; set; }
        public long ProductId { get; set; }
    }
}
