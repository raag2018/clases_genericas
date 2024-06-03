using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_genericas{
    public class CajaConConstructor<T> where T : new(){
        private T contenido;
        public CajaConConstructor(){
            contenido = new T(); // Se requiere que T tenga un constructor sin parámetros
        }
    }
}
