using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Consultor
    {
        public int IdConsultor { get; set; }
        public int IdFornecedor { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public decimal ValorHora { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
