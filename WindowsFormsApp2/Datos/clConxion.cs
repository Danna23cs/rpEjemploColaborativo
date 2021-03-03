using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Datos
{
    class clConxion
    {
        public int dato1 { get; set; }
        public int dato2 { get; set; }
        public int mtdComrpobarDatos()
        {
            int dato = dato1 * dato2;
            return dato;
            
        }
    }
}
