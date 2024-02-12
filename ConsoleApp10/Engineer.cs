using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Engineer:Employee
    {
        private int n;

        public Engineer() { }

        public Engineer(string name, string surname, DateTime birth, int p, int n) : base(name, surname, birth, p)
        {
            this.n = n;
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Кол-во разработанных проектов: {n}");
        }

        public new double Income() 
        {
           
        }
    }
}
