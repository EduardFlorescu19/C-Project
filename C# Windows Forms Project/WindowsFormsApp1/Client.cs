using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Client : ICloneable, IComparable
    {
        private string nume;
        private List<Credit> credite = new List<Credit>();

        public string Nume { get { return nume; } }
        public List<Credit> Credite { get { return credite; } }

        public Client(string nume)
        {
            this.nume = nume;
        }

        public object Clone()
        {
            Client client = new Client(this.nume);
            client.credite = new List<Credit>();
            foreach (Credit credit in this.credite)
            {
                client.credite.Add((Credit)credit.Clone());
            }
            return client;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Client otherClient = obj as Client;
            if (otherClient != null)
                return this.nume.CompareTo(otherClient.nume);
            else
                throw new ArgumentException("Object is not a Client");
        }


        public void AdaugaCredit(Credit credit)
        {
            this.credite.Add(credit);
        }

        public void StergeCredit(Credit credit)
        {
            this.credite.Remove(credit);
        }

        public void CalculeazaDobanda()
        {
            foreach (Credit credit in this.credite)
            {
                credit.CalculeazaDobanda();
            }
        }

        public void AfiseazaCredite()
        {
            Console.WriteLine("Creditele clientului " + this.nume + " sunt:");
            foreach (Credit credit in this.credite)
            {
                Console.WriteLine(credit);
            }
        }

    }
}
