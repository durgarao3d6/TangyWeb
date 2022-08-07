﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models.LearnBlazorModels
{
    public class Demo_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }  
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
    }
}
