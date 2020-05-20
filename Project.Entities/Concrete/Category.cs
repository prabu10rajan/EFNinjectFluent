﻿using Common.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public int CategoryName { get; set; }
    }
}
