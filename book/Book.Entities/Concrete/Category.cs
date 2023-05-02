﻿using Book.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsDeleted { get; set; }


        public IEnumerable<MyBook> MyBooks { get; set; }
    }
}