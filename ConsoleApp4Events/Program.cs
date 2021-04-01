using Models;
using System;

namespace ConsoleApp4Events
{
    class Program
    {
        static void Main(string[] args)
        {
            SuscriptorCalculadoraVirtual x = new(3, 2);
            x.OperacionSuma();
            x.OperacionResta();
        }
    }
}
