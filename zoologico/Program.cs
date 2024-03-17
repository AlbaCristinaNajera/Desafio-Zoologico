using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool abandonar = false;
            do
            {
                Console.WriteLine("--------Guía de visitas---------");
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar al León");
                Console.WriteLine("2. Visitar al Elefante");
                Console.WriteLine("3. Visitar a la Jirafa");
                Console.WriteLine("4. Visitar al Tigre");
                Console.WriteLine("5. Visitar al Mono");
                Console.WriteLine("6. Visitar al Oso");
                Console.WriteLine("7. Visitar al Cocodrilo");
                Console.WriteLine("8. Visitar a la Serpiente");
                Console.WriteLine("9. Visitar al Pinguino");
                Console.WriteLine("10. Visitar al Lobo");
                Console.WriteLine("11. Visitar a la Cebra");
                Console.WriteLine("12. Visitar al Rinoceronte");
                Console.WriteLine("13. Visitar al Panda");
                Console.WriteLine("14. Visitar al Pavo Real");
                Console.WriteLine("15. Visitar a la Tortuga");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("¿Qué animal deseas visitar?: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:abandonar = true; break;
                    case 1:VisitaZoologico.visitarLeon();break;
                    case 2:VisitaZoologico .visitarElefante();break;
                    case 3:VisitaZoologico.visitarJirafa();break;
                    case 4:VisitaZoologico.visitarTigre();break;
                    case 5: VisitaZoologico.visitarMono(); break;
                    case 6: VisitaZoologico.visitarOso(); break;
                    case 7: VisitaZoologico.visitarCocodrilo(); break;
                    case 8: VisitaZoologico.visitarSerpiente(); break;
                    case 9: VisitaZoologico.visitarPinguino(); break;
                    case 10: VisitaZoologico.visitarLobo(); break;
                    case 11: VisitaZoologico.visitarCebra(); break;
                    case 12: VisitaZoologico.visitarRinoceronte(); break;
                    case 13: VisitaZoologico.visitarPanda(); break;
                    case 14: VisitaZoologico.visitarPavoReal(); break;
                    case 15: VisitaZoologico.visitarTortuga(); break;

                }
                Console.ReadKey();
                Console.Clear();

            } while (!abandonar);

            Console.ReadKey(true);
        }
    }
}
