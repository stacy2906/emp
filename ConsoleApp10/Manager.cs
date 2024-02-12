using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Manager:Employee
    {
        private int sales;


        public Manager() { }
        public Manager(string name, string surname, DateTime birth, int p,int sales) :base(name, surname,birth,p)
        {
            this.sales = sales;
        }

        public int Sales
        { 
            get { return sales; }
            set { sales = value; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Объем продаж {sales}");
        }
        public override double Income(double k) 
        {
            double H = k * P;
            if (sales > H )
            {
                return H * 0.01;
            }
            else
            {
                return base.Income(k);
            }
            return k += H;
        }


    }
}
