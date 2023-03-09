﻿using AtSepete.Entities.Data;
using AtSepete.Repositories.Abstract;
using AtSepete.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtSepete.Repositories.Concrete
{
    public class ProductMarketRepository:GenericRepository<ProductMarket>,IProductMarketRepository
    {
        public ProductMarketRepository(AtSepeteDbContext Context):base(Context) 
        {

        }
    }
}
