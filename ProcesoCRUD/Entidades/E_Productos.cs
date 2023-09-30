using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoCRUD.Entidades
{
    public class E_Productos
    {
        public int Codigo_pr { get; set; }

        public string Descripcion_pr { get; set; }

        public string Marca_pr { get; set; }

        public int Codigo_me { get; set; }

        public int Codigo_ca { get; set; }

        public decimal Stock_actual { get; set; }
    }
}
