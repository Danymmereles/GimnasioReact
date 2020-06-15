using System;

namespace Gimnasio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBuen dia!!");
            Console.WriteLine("\nComencemos por los entrenadores"); 

            string opcion;
            bool validacion = true;
            string name;

            Boxeador boxeador = new Boxeador();

            Entrenador moscaGallo = new Entrenador ("MOSCA-GALLO");
            Entrenador plumaLigero = new Entrenador ("PLUMA-LIGERO");
            Entrenador welterMediano = new Entrenador ("WELTER-MEDIANO");
            Entrenador mediopesadoPesado = new Entrenador ("MEDIOPESADO-PESADO");

            PresentadorRing pr = new PresentadorRing ();
            SelectorCategoria sr = new SelectorCategoria ();

            string apellido;
            int edad;
            double altura;
            double peso;

            while (validacion)
            {
                Console.WriteLine("Desea registrarlos con nombres? (Si/No)");
                opcion = Console.ReadLine();

                if (opcion != "Si" && opcion != "No")
                {
                    Console.WriteLine("Lo lamento, debe ingresar alguno de los valores dichos, Si o No");
                } 
                else
                {
                    validacion = false;

                    if (opcion == "Si")
                    {
                        Console.WriteLine("\nInserte sus nombres por favor");
                        Console.WriteLine("\nEl entrenador de las categorias MOSCA y GALLO: ");
                        moscaGallo.nombre = Console.ReadLine();
                        Console.WriteLine("\nEl entrenador de las categorias PLUMA y LIGERO: ");
                        plumaLigero.nombre = Console.ReadLine();
                        Console.WriteLine("\nEl entrenador de las categorias WELTER y MEDIANO: ");
                        welterMediano.nombre = Console.ReadLine();
                        Console.WriteLine("\nEl entrenador de las categorias MEDIOPESADO y PESADO: ");
                        mediopesadoPesado.nombre = Console.ReadLine();
                    }
                    else
                    {
                        moscaGallo.nombre = "sin nombre";
                        plumaLigero.nombre = "sin nombre";
                        welterMediano.nombre = "sin nombre";
                        mediopesadoPesado.nombre = "sin nombre";
                    }
                }
            
            }

            Console.WriteLine("\nComenzando registro de boxeadores...");
            
            opcion = "Si";
            validacion = true;
            
            while (validacion)
            {
                if (opcion != "Si" && opcion != "No")
                {
                    Console.WriteLine("Lo lamento, debe ingresar alguno de los valores dichos, Si o No");
                    opcion = Console.ReadLine();
                } 
                else
                {
                    if (opcion == "No")
                    { 
                        validacion = false;

                    }else{

                        Console.WriteLine("\nIngrese el nombre");
                        name = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el edad");
                        edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el altura");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el peso");
                        peso = Convert.ToDouble(Console.ReadLine()); 

                        boxeador.cargarDatos (name, apellido, edad, altura, peso, sr.darCategoria(peso));

                        pr.mostrarBoxeador(boxeador);

                        switch (boxeador.categoria)
                        {
                            case "MOSCA":
                            case "GALLO":
                                moscaGallo.agregarBoxeador(boxeador);
                                if (pr.esEntrenadorDe(moscaGallo, boxeador) == 1)
                                {
                                    boxeador.entrenadorDesignado = moscaGallo;
                                } else {
                                    Console.WriteLine("\nLamentamos, pero la lista de " + moscaGallo.nombre + " de " + moscaGallo.categoria + " esta llena, no pudo ingresar \nIntentelo mañana nuevamente");
                                }
                                break;
                            case "PLUMA":
                            case "LIGERO":
                                plumaLigero.agregarBoxeador(boxeador);
                                if (pr.esEntrenadorDe(plumaLigero, boxeador) == 1)
                                {
                                    boxeador.entrenadorDesignado = plumaLigero; 
                                } 
                                else 
                                {
                                    Console.WriteLine("\nLamentamos, pero la lista de " + plumaLigero.nombre + " de " + plumaLigero.categoria + " esta llena, no pudo ingresar \nIntentelo mañana nuevamente");
                                }
                               
                                break;
                            case "WELTER":
                            case "MEDIANO":
                                welterMediano.agregarBoxeador(boxeador);
                                if (pr.esEntrenadorDe(welterMediano, boxeador) == 1)
                                {
                                    boxeador.entrenadorDesignado = welterMediano;
                                } else {
                                    Console.WriteLine("\nLamentamos, pero la lista de " + welterMediano.nombre + " de " + welterMediano.categoria + " esta llena, no pudo ingresar \nIntentelo mañana nuevamente");
                                }
                                
                                break;
                            case "MEDIOPESADO":
                            case "PESADO":
                                mediopesadoPesado.agregarBoxeador(boxeador);
                                if (pr.esEntrenadorDe(mediopesadoPesado, boxeador) == 1)
                                {
                                    boxeador.entrenadorDesignado = mediopesadoPesado;
                                } else {
                                    Console.WriteLine("\nLamentamos, pero la lista de " + mediopesadoPesado.nombre + " de " + mediopesadoPesado.categoria + " esta llena, no pudo ingresar \nIntentelo mañana nuevamente");
                                }
                                
                                break;
                            
                        }

                        if (pr.esEntrenadorDe(boxeador.entrenadorDesignado, boxeador) == 1){
                            if (boxeador.entrenadorDesignado.nombre != "sin nombre")
                            {
                                Console.WriteLine("\nSu entrenador sera: " + boxeador.entrenadorDesignado.nombre);
                                pr.mostrarEntrenadores(boxeador.entrenadorDesignado); 
                            } else {
                                Console.WriteLine("\nEl entrenador sera el encargado de: " + boxeador.entrenadorDesignado.categoria);
                                pr.mostrarEntrenadores(boxeador.entrenadorDesignado); 
                            }
                        } 
                        

                        Console.WriteLine("\nDesea registrar mas boxeadores? (Si/No)");
                        opcion = Console.ReadLine();
                    }
                }
                
            }

            Console.WriteLine("\nMostramos a los entrenadores");

            pr.mostrarEntrenadores(moscaGallo);
            pr.mostrarEntrenadores(plumaLigero);
            pr.mostrarEntrenadores(welterMediano);
            pr.mostrarEntrenadores(mediopesadoPesado);

            Console.WriteLine("\nMuchas gracias por usar nuestros servicios, esperamos que vuelva pronto!");

        }
    }
}
