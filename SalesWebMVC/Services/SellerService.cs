﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }


        //lista com todos Vendedores do banco
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
