using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SuscriptorCalculadoraVirtual
    {
        private EditorCalculadora editor;
        private int A;
        private int B;

        public void EjemploEventHandler()
        {
            Console.WriteLine("La operación va a ser ejecutada.");
        }
        public void EjemploEventHandler2()
        {
            Console.WriteLine("este es nuestro segundo evento.");
        }


        public SuscriptorCalculadoraVirtual(int a, int b)
        {
            editor = new EditorCalculadora();
            A = a;
            B = b;
            editor.EjemploEvento += EjemploEventHandler;
            editor.EjemploEvento += EjemploEventHandler2;

        }

        public void OperacionSuma()
        {
            editor.Sumar(A, B);
        }

        public void OperacionResta()
        {
            editor.Resta(A, B);
        }
    }
}
