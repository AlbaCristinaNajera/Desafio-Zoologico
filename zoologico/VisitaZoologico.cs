using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class VisitaZoologico
    {
        public static void visitarLeon()
        {
            Leon leon = new Leon("Alex", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", leon);
            leon.mover();
            leon.sonar();
            leon.comer();
        }

        public static void visitarElefante()
        {
            Elefante elefante = new Elefante("Sergio", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", elefante);
            elefante.mover();
            elefante.sonar();
            elefante.comer();
        }

        public static void visitarJirafa()
        {
            Jirafa jirafa = new Jirafa("Lupita", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", jirafa);
            jirafa.mover();
            jirafa.sonar();
            jirafa.comer();
        }

        public static void visitarTigre()
        {
            Tigre tigre = new Tigre("Camilo", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", tigre);
            tigre.mover();
            tigre.sonar();
            tigre.comer();
        }

        public static void visitarMono()
        {
            Mono mono = new Mono("Kiki", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", mono);
            mono.mover();
            mono.sonar();
            mono.comer();
        }

        public static void visitarOso()
        {
            Oso oso = new Oso("bebé", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", oso);
            oso.mover();
            oso.sonar();
            oso.comer();
        }

        public static void visitarCocodrilo()
        {
            Cocodrilo cocodrilo = new Cocodrilo("Gruñon", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", cocodrilo);
            cocodrilo.mover();
            cocodrilo.sonar();
            cocodrilo.comer();
        }

        public static void visitarSerpiente()
        {
            Serpiente serpiente = new Serpiente("Sagas", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", serpiente);
            serpiente.mover();
            serpiente.sonar();
            serpiente.comer();
        }

        public static void visitarPinguino()
        {
            Pinguino pinguino = new Pinguino("Copito", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", pinguino);
            pinguino.mover();
            pinguino.sonar();
            pinguino.comer();
        }

        public static void visitarLobo()
        {
            Lobo lobo = new Lobo("Lili", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", lobo);
            lobo.mover();
            lobo.sonar();
            lobo.comer();
        }

        public static void visitarCebra()
        {
            Cebra cebra = new Cebra("Martin", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", cebra);
            cebra.mover();
            cebra.sonar();
            cebra.comer();
        }

        public static void visitarRinoceronte()
        {
            Rinoceronte rinoceronte = new Rinoceronte("Gorda", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", rinoceronte);
            rinoceronte.mover();
            rinoceronte.sonar();
            rinoceronte.comer();
        }

        public static void visitarPanda()
        {
            Panda panda = new Panda("Cariñitos", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", panda);
            panda.mover();
            panda.sonar();
            panda.comer();
        }

        public static void visitarPavoReal()
        {
            PavoReal pavoreal  = new PavoReal("Tirito", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", pavoreal);
            pavoreal.mover();
            pavoreal.sonar();
            pavoreal.comer();
        }

        public static void visitarTortuga()
        {
            Tortuga tortuga = new Tortuga("Ninja", "Macho");
            Console.WriteLine("Bienvenido a la jaula de: {0} ", tortuga);
            tortuga.mover();
            tortuga.sonar();
            tortuga.comer();
        }




    }
}
