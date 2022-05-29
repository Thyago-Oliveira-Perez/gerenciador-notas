using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.Entities
{
    public class Extrato : BaseEntity
    {
        public string data { get; set; }
        public double valor { get; set; }

    }
}
