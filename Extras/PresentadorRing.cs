using System;

namespace Gimnasio
{
    
    public class PresentadorRing {

        public void mostrarEntrenadores(Entrenador coach)
        {
            if (coach.nombre != "sin nombre")
            {
                Console.WriteLine("\nNombre: " + coach.nombre);
            } else {
                Console.WriteLine("\n");
            }

            Console.WriteLine("Categorias: " + coach.categoria);
            Console.WriteLine("Tiene " + coach.listaParaEntrenar.Count + " de Boxeadores para entrenar");

            int i = 0;
            foreach (Boxeador item in coach.listaParaEntrenar)
            {
                mostrarBoxeador(coach.listaParaEntrenar[i]);
                i++;
            }
        }

        public void mostrarBoxeador(Boxeador boxeador)
        {
            Console.WriteLine("\t\tNombre: " + boxeador.nombre);
            Console.WriteLine("\t\tApellido: " + boxeador.apellido);
            Console.WriteLine("\t\tEdad: " + boxeador.edad);
            Console.WriteLine("\t\tAltura: " + boxeador.altura);
            Console.WriteLine("\t\tPeso: " + boxeador.peso);
            Console.WriteLine("\t\tCategoria: " + boxeador.categoria + "\n");
        }
        
        public int esEntrenadorDe(Entrenador entrenador, Boxeador boxeador){
            for(int i = 0; i < entrenador.listaParaEntrenar.Count; i++){
                if (entrenador.listaParaEntrenar[i].Equals(boxeador)){
                    return 1;
                }
            }
            return 0;
        }
    }

}