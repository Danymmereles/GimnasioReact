using System;

namespace Gimnasio
{
    
    public class SelectorCategoria {
        
        public string darCategoria (double peso)
        {

            if (peso < 52.163){

                Console.WriteLine("Este boxeador quedaria en la categoria: MOSCA");

                if (peso < 48.988){Console.WriteLine("En el caso de quedar, se le dara una dieta especial para subir de peso.");}

                if (peso > 50.802){superoLimite();}

                return "MOSCA";

            }

            if (peso < 55.338){

                Console.WriteLine("Este boxeador quedaria en la categoria: GALLO");

                if (peso > 53.525){superoLimite();}

                return "GALLO";

            }

            if (peso < 58.967){

                Console.WriteLine("Este boxeador quedaria en la categoria: PLUMA");

                if (peso > 57.152){superoLimite();}

                return "PLUMA";

            }

            if (peso < 63.503){

                Console.WriteLine("Este boxeador quedaria en la categoria: LIGERO");

                if (peso > 61.237){superoLimite();}

                return "LIGERO";

            }

            if (peso < 69.853){

                Console.WriteLine("Este boxeador quedaria en la categoria: WELTER");

                if (peso > 66.678){superoLimite();}

                return "WELTER";

            }

            if (peso < 76.205){

                Console.WriteLine("Este boxeador quedaria en la categoria: MEDIANO");

                if (peso > 72.562){superoLimite();}

                return "MEDIANO";

            }

            if (peso < 91.000){

                Console.WriteLine("Este boxeador quedaria en la categoria: MEDIOPESADO");

                if (peso > 79.378){superoLimite();}

                return "MEDIOPESADO";

            }

            Console.WriteLine("Este boxeador quedaria en la categoria: PESADO");

            return "PESADO";

        }

        public void superoLimite (){
            Console.WriteLine("En el caso de quedar, debera bajar de peso con el entrenamiento.");
        }
    }
}
