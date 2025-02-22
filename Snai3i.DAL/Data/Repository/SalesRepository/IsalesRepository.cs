﻿using Snai3i.DAL.Data.Models;
using Snai3i.DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i.DAL.Data.Repository.SalesRepository
{
    public interface IsalesRepository : IGenericRepository<Sales>
    {
        // with include 
        Task<IEnumerable<Sales>> GetAllSalesAsync();

        Task<Sales> GetSalesByIDAsync(int id); 


    }
}
