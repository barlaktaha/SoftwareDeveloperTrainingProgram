﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
