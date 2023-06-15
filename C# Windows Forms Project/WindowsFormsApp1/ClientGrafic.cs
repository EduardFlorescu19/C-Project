using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ClientGrafic
    {
        private string nume;
        private int sumaImprumutata;

        public ClientGrafic(string nume, int sumaImprumutata)
        {
            this.nume = nume;
            this.sumaImprumutata = sumaImprumutata;
        }

        public string Nume { get { return nume; } }

        public int SUmaImprumutata { get {  return sumaImprumutata; } }
    }
}
