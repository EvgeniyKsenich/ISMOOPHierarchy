using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK_Client:Human, IBank
    {
        protected double suma;
        protected double credit_cart;
        protected int num;
        protected bool credit_c;
        protected bool suma_c;


        public BANK_Client(string name, string surname, int num, double suma, double credit_cart) :base(name, surname)
        {
            this.num = num;
            this.suma = suma;
            this.credit_cart = credit_cart;
            credit_c = true;
            suma_c = true;
        }

        public void AnulateBank()
        {
            suma_c = false;
        }
        public void StartBank()
        {
            suma_c = true;
        }

        public void AnulateCard()
        {
            credit_c = false;
        }
        public void StartCard()
        {
            credit_c = true;
        }

        public void Pay(double pay_sum)
        {
            suma -= pay_sum;
        }

        public void Input(double pay_sum)
        {
            suma += pay_sum;
        }
        public override void Print()
        {
            base.Print();
            Console.Write("Bank suma:" + suma);
            if(suma_c) Console.Write(" (unloc)\n");
            else Console.Write(" (loc)\n");
            Console.Write("Credit suma:" + credit_cart);
            if (credit_c) Console.Write(" (unloc)\n");
            else Console.Write(" (loc)\n");

        }
    }
}
