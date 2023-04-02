﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtSepete.Dtos.Dto
{
    public class UpdateProductMarketDto
    {
        public Guid Id { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
    }
}
