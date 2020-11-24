﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroia_Roxana_Cristina_Lab8.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
