using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructure
{
    internal class SalesMen :Employee
    {
        public SalesMen(int id, string name, int salary, int Allowance) : base(id, name, salary)
        {
            this.Allowance = Allowance;
        }

        public int Allowance { get; set; }
    }
}
