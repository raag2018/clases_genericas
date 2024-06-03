using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_genericas{
    public class CajaConRestriccion<T> where T : class{
        private T contenido;
        public CajaConRestriccion(T contenidoInicial){
            contenido = contenidoInicial;
        }
    }
}
