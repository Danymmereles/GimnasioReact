using System;

namespace Gimnasio
{
    public class Boxeador {
        
        public string nombre {set; get;}

        public string apellido {set; get;}

        public int edad {set; get;}

        public double altura {set; get;}

        public double peso {set; get;}

        public Entrenador entrenadorDesignado {set; get;}

        public string categoria {set; get;}

        public void cargarDatos (string name, string apellido, int edad, double altura, double peso, string categoria){
            this.nombre = name;
            this.apellido = apellido;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
            this.categoria = categoria;
        }

        public Boxeador (){
            this.entrenadorDesignado = new Entrenador();
        }

        public Boxeador (Boxeador boxeador){
            this.nombre = boxeador.nombre;
            this.apellido = boxeador.apellido;
            this.edad = boxeador.edad;
            this.altura = boxeador.altura;
            this.peso = boxeador.peso;
            this.categoria = boxeador.categoria;
        }
 
    }
}