using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    class Telefono
    {
        //CONSTRUCTOR
        public Telefono(string modelo, string marca) 
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        //ATRIBUTOS
        private string modelo, marca, numeroTelefonico;
        private int codigoOperador;

        //PROPIEDADES
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador
        {
            get {  return codigoOperador; }
            set
            {
                if (value > 3 || value < 1)
                {
                    codigoOperador = 0;
                }
                else
                {
                    codigoOperador = value;
                }
            }
        }

        //METODO CON SOBRECARGA
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
