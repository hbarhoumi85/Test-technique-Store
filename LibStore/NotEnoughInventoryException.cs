﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStore
{
    public class NotEnoughInventoryException: Exception
    {
        public IEnumerable<INameQuantity> Missing { get; }
    }
}
