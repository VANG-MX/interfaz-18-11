using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    public class Empleado
    {
        string nombre;
        int n_reloj;


            public Empleado(string n, int nr)
        {
            this.nombre = n;
            this.n_reloj = nr;
        }

        public string Nombre { get { return nombre; } }
        
        public int N_reloj { get { return n_reloj;} }

        public override string ToString()
        {
            string s = this.nombre + this.n_reloj;
            return s;
        }
    }
}
