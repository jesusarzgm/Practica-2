using System;

namespace Practica2
{
    class Datos:Promedio 
    {
        private int sexo;
        //constructor 1
        public Datos()
        {
            Console.WriteLine("\nIngresa tu nombre:");
            Nombre = Console.ReadLine();
            Bienvenida();
            Console.WriteLine("\n¿Cuantos años tienes?");
            Edad = Int16.Parse(Console.ReadLine());
            Años();
            Console.WriteLine("\nSeleccione una opcion: \n\t1:hombre   2:mujer");
            sexo = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n¿Cual es tu promedio?");
            Calificaciones = Convert.ToSingle(Console.ReadLine());
            Calif();
             

        }
        public override void Bienvenida()
        {
            base.Bienvenida();
            Console.WriteLine("\nA continuación se mostrara tu promedio y si es posible que participes en alguna beca");
            Console.WriteLine("\nPero antes necesitamos que llenes algunos datos:\n");
        }

        public override void Años()
        {
            base.Años();
            if (Edad >= 18)
            {
                Console.WriteLine("\nDependiendo de tu promedio entrarias a las becas como mayor de edad");
            }
            else
            {
                Console.WriteLine("\nDependiendo de tu promedio entrarias a las becas como menor de edad");
            }

        }
        public override void Calif()
        {
            base.Calif();
            if (Calificaciones >= 8.5)
            {
                if (sexo != 1)
                {
                    Console.WriteLine("Felicidades, puedes participar en apoyo para mujeres, economicos y de investigacion");
                }
                else
                {
                    Beca();
                }
            }
            else
            {
                Console.WriteLine("Lo sentimos no alcanzas el promedio");
            }
        }
    }
}
