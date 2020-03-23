﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class Parent : User
    {
        public virtual ICollection<CarPool> CarPools { get; set; }
        public virtual ICollection<Kid> Kids { get; set; }
    }
}
