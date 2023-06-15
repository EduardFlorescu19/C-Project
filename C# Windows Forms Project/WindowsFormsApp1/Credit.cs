using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Credit : ICloneable, IComparable<Credit>
    {
        private int id;
        private string numeClient;
        private decimal sumaImprumutata;
        private int durataInLuni;
        private decimal dobandaAnuala;

        public int Id { get { return id; } }
        public string NumeClient { get { return numeClient; } }
        public decimal SumaImprumutata { get { return sumaImprumutata; } }
        public int DurataInLuni { get { return durataInLuni; } }
        public decimal DobandaAnuala { get { return dobandaAnuala; } }

        public Credit(int id, string numeClient, decimal sumaImprumutata, int durataInLuni, decimal dobandaAnuala)
        {
            this.id = id;
            this.numeClient = numeClient;
            this.sumaImprumutata = sumaImprumutata;
            this.durataInLuni = durataInLuni;
            this.dobandaAnuala = dobandaAnuala;
        }

        public abstract decimal CalculeazaDobanda();

        public int CompareTo(Credit other)
        {
            if (this.sumaImprumutata > other.sumaImprumutata)
                return 1;
            else if (this.sumaImprumutata < other.sumaImprumutata)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static bool operator >(Credit c1, Credit c2)
        {
            return c1.sumaImprumutata > c2.sumaImprumutata;
        }

        public static bool operator <(Credit c1, Credit c2)
        {
            return c1.sumaImprumutata < c2.sumaImprumutata;
        }

        public static Credit operator ++(Credit c)
        {
            c.durataInLuni++;
            return c;
        }

        public static explicit operator decimal(Credit c)
        {
            return c.CalculeazaDobanda();
        }

        public override string ToString()
        {
            return $"Credit ID: {id}\nNume client: {numeClient}\nSuma imprumutata: {sumaImprumutata}\nDurata in luni: {durataInLuni}\nDobanda anuala: {dobandaAnuala}";
        }

    }
}

