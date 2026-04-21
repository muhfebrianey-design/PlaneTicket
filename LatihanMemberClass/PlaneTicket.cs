using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
        //Field
        private string _origin;
        private string _destination;
        private int _cost;
        private string _currency;
        //Properties untuk menyimpan data tiket
        public string Origin 
        {
            get { return _origin;}
            set { _origin = value; }
        }
        public string Destination
        {
            get { return _destination;}
            set { _destination = value; }
        }
        public int Cost
        {
            get { return _cost;}
            set { _cost = value; }
        }
        public string Currency
        {
            get { return _currency;}
            set { _currency = value; }
        }

        //Method untuk menampilkan tiket dan konversi mata uang
        public void PrintSummary()
        {
            Console.WriteLine("Origin: {0}", Origin);
            Console.WriteLine("Destination: {0}", Destination);
            Console.WriteLine("Cost: {0} ({1})", Cost, Currency);

            //Logika konversi dengan asumsi 1 USD = 15.000 IDR
            if (Currency == "USD")
            {
                int convertToRupiah = Cost * 15000;
                Console.WriteLine("Convert to Rupiah:{0}", convertToRupiah);
            }
            else if (Currency == "IDR")
            {
                int convertToDollar = Cost / 15000;
                Console.WriteLine("Convert to Dollar:{0}", convertToDollar);
            }
        }
    }
}
