using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Alarma
    {
        //ATRIBUTOS
        private string claveFija, claveIngreso;
        //CONSTRUCTOR
        public Alarma(string claveFija)
        {
            this.claveFija = claveFija;
        }
        //PROPIEDADES
        public string ClaveFija { get; }
        public string ClaveIngreso { get; set; }
        //METODOS
        public bool Verificador()
        {
            if (this.claveFija != ClaveIngreso)
            {
                return false;
            }
            else
            {
                return true;
            }
         
    }   }
}
