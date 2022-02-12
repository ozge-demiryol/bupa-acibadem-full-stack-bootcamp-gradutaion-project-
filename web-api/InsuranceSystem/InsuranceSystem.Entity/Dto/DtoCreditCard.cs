using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoCreditCard : DtoBase
    {
        public DtoCreditCard()
        {

        }

        public int CardId { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ExpDate { get; set; }
        public string Cvv { get; set; }
    }
}
