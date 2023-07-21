using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.Model
{
    internal class Student
    {
        public int ID { get; set; }
        public string SName { get; set; }

        public int Semister { get; set; }
        public string Hobby { get; set; }
    }
}
