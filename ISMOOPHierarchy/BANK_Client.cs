using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BANK_Client:Human, IBank, ICloneable, IComparable<BANK_Client>
    {
        protected double suma;
        protected double credit_cart;
        protected int num;
        protected bool credit_c;
        protected bool suma_c;

        protected bool Cr_c
        {
            get { return credit_c; }
            set { credit_c = value; }
        }
        protected bool Sum_c
        {
            get { return suma_c; }
            set { suma_c = value; }
        }
        protected double Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        protected double CrCr
        {
            get { return credit_cart; }
            set { credit_cart = value; }
        }
        protected int Nm
        {
            get { return num; }
            set { num = value; }
        }
        


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

        public object Clone()
        {
            BANK_Client tmp = new BANK_Client(this.Name, this.Surname, this.Nm, this.Suma, this.CrCr);
            tmp.Sum_c = this.Sum_c;
            tmp.Cr_c = this.Cr_c;
            return tmp;
        }

        public int CompareTo(BANK_Client other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            int cmp = base.CompareTo(tmp);
            if (cmp == 0) return Nm.CompareTo(other.Nm);
            else
                return cmp;
        }
    }
}
