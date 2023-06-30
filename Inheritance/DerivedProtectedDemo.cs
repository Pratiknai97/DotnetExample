using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DerivedProtectedDemo :ProtectedDemo
    {
        public string Name { get; set; }
        public string GetData()
        {
            return ID.ToString();
        }
    }

}
