using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //any serve para testar se existe algum registro
            if ( _context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any() )
            {
                return; //banco já foi populado
            }

            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            //outra sintaxe:
            Department d5 = new Department { Id = 5, Name = "Furnitures"};


            Seller s1 = new Seller(1, "Tiago Goncalves", "tiago@gmail.com", new DateTime(1192, 9, 14), 10000.0, d1);
            Seller s2 = new Seller(2, "Maria Red", "Maria@gmail.com", new DateTime(1192, 9, 14), 10000.0, d2);
            Seller s3 = new Seller(3, "Alex Gray", "Alex@gmail.com", new DateTime(1192, 9, 14), 10000.0, d1);
            Seller s4 = new Seller(4, "Martha Blue", "Martha@gmail.com", new DateTime(1192, 9, 14), 10000.0, d4);
            Seller s5 = new Seller(5, "Donald Green", "Donald@gmail.com", new DateTime(1192, 9, 14), 10000.0, d3);
            Seller s6 = new Seller(6, "Alex Yellow", "Alex@gmail.com", new DateTime(1192, 9, 14), 10000.0, d2);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleSatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 21), 11000.0, SaleSatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 09, 25), 11000.0, SaleSatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2015, 09, 25), 11000.0, SaleSatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2011, 09, 25), 11000.0, SaleSatus.Billed, s3);

            //adicionando os dados ao banco
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5);

            //salvando no banco
            _context.SaveChanges();



        }

    }
}
