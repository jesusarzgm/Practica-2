using System;

namespace Practica2
{
    public abstract class Promedio   //clase padre
    {
        private string nombre;
        private int edad;
        private float calificaciones;
        
        //Encapsulamiento
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public float Calificaciones
        {
            get
            {
                return calificaciones;

            }
            set
            {
                calificaciones = value;
            }
        }



        public virtual void Bienvenida ()
        {
            Console.WriteLine("\tBienvenid@: {0}", nombre);
        }
        public virtual void Beca ()
        {
            Console.WriteLine("\nEnhora buena, puedes solicitar una beca de apoyo economico o de investigacion");
        }
        public virtual void Años ()
        {
            Console.WriteLine("\n\tTu edad es: {0}", edad);
        }
        public virtual void Calif ()
        {
            Console.WriteLine("\n\tTu promedio es:{0} ", calificaciones);
        }
    
    
    }
}
