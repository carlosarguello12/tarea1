using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            menu();
        }
       

        public static void menu()//metodo para desplegar menu
        {
            int opcion = 0; // Variable para opcion de menu 
            do
            {
                Console.WriteLine("Bienvenido al modulo de profesores");
                Console.WriteLine("1 - Notas de estudiantes ");
                Console.WriteLine("2- Nombres de Estudiantes");
                Console.WriteLine("3 Salir");
                opcion= int.Parse(Console.ReadLine());
                

                switch (opcion)
                {
                    case 1: pedirnotas();break;
                    case 2: pedirnombres();break;
                    case 3: break;
                    default: Console.WriteLine(" Error digite una opcion valida");break;

                }
            } while (opcion != 3); //Valor para salir del menu 
            
        }

        public static void pedirnotas() //metodo para solicitar y almacenar notas
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            int nota5 = 0;

            Console.WriteLine("Digite la nota del estudiante 1");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del estudiante 2");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del estudiante 3");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del estudiante 4");
            nota4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del estudiante 5");
            nota5 = int.Parse(Console.ReadLine());

            int[] notas = new int[5];// Vector para almacenar notas 
            notas[0] = nota1;
            notas[1] = nota2;
            notas[2] = nota3;
            notas[3] = nota4;
            notas[4] = nota5;
           

            int menunota = 0;
            do
                
            {
                Console.WriteLine (" Que desea realizar con las notas");
                Console.WriteLine("1-Promedio");
                Console.WriteLine("2-Nota Mayor");
                Console.WriteLine("3- Nota Menor");
                Console.WriteLine("4-Salir");
               menunota = int.Parse(Console.ReadLine());
                
                switch (menunota)
                {
                    case 1: // Promedio de Notas
                        float sumatoria = 0;

                        for (int i = 0; i < notas.Length; i++)
                        {
                            sumatoria += notas[i];
                        }

                        sumatoria /= 5;
                        sumatoria = sumatoria / 5;
                        Console.WriteLine(sumatoria);

                        break;

                    case 2: // Mayor nota
                        int mayor = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (mayor < notas[i + 1])
                            {
                                mayor = notas[i];
                            }
                        }
                        Console.WriteLine("La nota mayor es ", mayor);
                        break;

                    case 3: // Menor nota 
                        int menor = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (menor > notas[i + 1])
                            {
                                menor = notas[i];
                            }
                        }
                        Console.WriteLine("El menor es ", menor);
                        break;

                    case 4: break;
                    default: Console.WriteLine(" Error digite una opcion valida"); break;


                }
            
            }while (menunota != 4);

















        }

        public static void pedirnombres()// metodo para pedir y almacenar nombres
        {
            string nombre1;
            string nombre2;
            string nombre3;
            string nombre4;
            string nombre5;

            Console.WriteLine("Digite el nombre del estudiante 1");
            nombre1= Console.ReadLine();
            Console.WriteLine("Digite el nombre del estudiante 2");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Digite el nombre del estudiante 3");
            nombre3 = Console.ReadLine();
            Console.WriteLine("Digite el nombre del estudiante 4");
            nombre4 = Console.ReadLine();
            Console.WriteLine("Digite el nombre del estudiante 5");
            nombre5 = Console.ReadLine();

            string[] estudiantes = new string[] { nombre1, nombre2, nombre3, nombre4, nombre5 };//vector para imprimir nombres de los estudiantes

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine( estudiantes[i]);
            }
        }
       

    }
}
