using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class marca
    {
        public string Nombre
        { get; set; }
        public marca()
        {
            Nombre = "Sin Marca";
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
