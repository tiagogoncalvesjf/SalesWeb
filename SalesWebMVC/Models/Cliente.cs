using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Cliente
    {
        private readonly SalesWebMvcContext _salesWebMvcContext;

        public Cliente(SalesWebMvcContext salesWebMvcContext)
        {
            _salesWebMvcContext = salesWebMvcContext;
        }


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string Observacao { get; set; }


        

   



    }
}
