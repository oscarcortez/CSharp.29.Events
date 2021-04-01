using System;

namespace Models
{
    public class EditorCalculadora
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado EjemploEvento;

        public void Sumar(int a, int b)
        {
            if (EjemploEvento != null)
            {
                EjemploEvento();
                Console.WriteLine($"la suma es {a + b}");
            }
            else
            {
                Console.WriteLine($"No estas suscrito a los eventos.");
            }

        }

        public void Resta(int a, int b)
        {
            if (EjemploEvento != null)
            {
                EjemploEvento();
                Console.WriteLine($"la resta es {a - b}");
            }
            else
            {
                Console.WriteLine($"No estas suscrito a los eventos.");
            }

        }
    }    
}
