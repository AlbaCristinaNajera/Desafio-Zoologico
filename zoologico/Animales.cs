using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    class Leon
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "León";

        public Leon(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Leon(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Camina");
        }

        public void comer()
        {
            Console.WriteLine("Come carne");
        }

        public void sonar()
        {
            Console.WriteLine("Grrrr");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }


    }

    class Elefante
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Elefante";

        public Elefante(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Elefante(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Camina");
        }

        public void comer()
        {
            Console.WriteLine("Come hiervas");
        }

        public void sonar()
        {
            Console.WriteLine("pffffu");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }

    }

    class Jirafa
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Jirafa";

        public Jirafa(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Jirafa(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Camina");
        }

        public void comer()
        {
            Console.WriteLine("Come hiervas");
        }

        public void sonar()
        {
            Console.WriteLine("mmmm");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Tigre
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Tigre";

        public Tigre(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Tigre(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Caza");
        }

        public void comer()
        {
            Console.WriteLine("Come carne");
        }

        public void sonar()
        {
            Console.WriteLine("¡Grrr!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Mono
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Mono";

        public Mono(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Mono(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine(" se cuelga");
        }

        public void comer()
        {
            Console.WriteLine("Come bananos");
        }

        public void sonar()
        {
            Console.WriteLine("¡uuhaaa!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Oso
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Oso";

        public Oso(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Oso(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Camina");
        }

        public void comer()
        {
            Console.WriteLine("Come pescado");
        }

        public void sonar()
        {
            Console.WriteLine("¡AAAGR!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Cocodrilo
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Cocodrilo";

        public Cocodrilo(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Cocodrilo(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Nada");
        }

        public void comer()
        {
            Console.WriteLine("Come carne");
        }

        public void sonar()
        {
            Console.WriteLine("¡mmmgrs!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Serpiente
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Serpiente";

        public Serpiente(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Serpiente(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Se arrastra");
        }

        public void comer()
        {
            Console.WriteLine("Come carne, huevos");
        }

        public void sonar()
        {
            Console.WriteLine("¡Sssss!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Pinguino
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Pinguino";

        public Pinguino(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Pinguino(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come pescado");
        }

        public void sonar()
        {
            Console.WriteLine("¡wek wek!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Lobo
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Lobo";

        public Lobo(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Lobo(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come carne");
        }

        public void sonar()
        {
            Console.WriteLine("¡Auuuuu!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Cebra
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Cebra";

        public Cebra(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Cebra(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come hiervas");
        }

        public void sonar()
        {
            Console.WriteLine("¡ppff!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Rinoceronte
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Rinoceronte";

        public Rinoceronte(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Rinoceronte(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come hiervas");
        }

        public void sonar()
        {
            Console.WriteLine("¡Ppff!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Panda
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Panda";

        public Panda(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Panda(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come bambú");
        }

        public void sonar()
        {
            Console.WriteLine("¡jhfggh!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class PavoReal
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Pavo Real";

        public PavoReal(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public PavoReal(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come semillas");
        }

        public void sonar()
        {
            Console.WriteLine("¡kii!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

    class Tortuga
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Tortuga";

        public Tortuga(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Tortuga(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("camina");
        }

        public void comer()
        {
            Console.WriteLine("Come hojas");
        }

        public void sonar()
        {
            Console.WriteLine("¡Aaah!");
        }

        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
        }
    }

}