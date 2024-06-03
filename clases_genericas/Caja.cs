using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_genericas{
    public class Caja<T>{
        private T contenido;
        public Caja(T contenidoInicial){
            contenido = contenidoInicial;
        }
        public T ObtenerContenido(){
            return contenido;
        }
        public void CambiarContenido(T nuevoContenido){
            contenido = nuevoContenido;
        }
    }
}
