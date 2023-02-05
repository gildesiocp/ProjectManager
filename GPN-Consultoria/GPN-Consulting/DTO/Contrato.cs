using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int IdClienteFornecedor { get; set; }
        public DateTime DtVigInicio { get; set; }
        public DateTime DtVigTermino { get; set; }
        public decimal VlrHoraHomem { get; set; }
        public int PrzFatEmDias { get; set; }
        public string Status { get; set; }
    }
}
