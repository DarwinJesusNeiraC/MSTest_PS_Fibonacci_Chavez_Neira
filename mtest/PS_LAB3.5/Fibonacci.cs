using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_LAB3._5
{
    public class Fibonacci
    {
        public int CalcularFibonacci(int n)
        {

            if (n <= 0)
                throw new ArgumentException("El número debe ser mayor que cero.", nameof(n));

            if (n == 1 || n == 2)
                return 1;

            int fib1 = 1;
            int fib2 = 1;
            int fibonacci = 0;

            for (int i = 3; i <= n; i++)
            {
                try
                {
                    checked
                    {
                        fibonacci = fib1 + fib2;
                    }
                    
                }
                catch(OverflowException) 
                { 
                    throw new ArgumentException("Se produjo desbordamiento");
                }
                
                fib1 = fib2;
                fib2 = fibonacci;
            }
            return fibonacci;
        }

        public int CalcularFibonacci()
        {
            throw new ArgumentException("Debe ingresar un parámetro a la vez");
        }

        public int CalcularFibonacci(int? n)
        {
            if (n == null)
                throw new ArgumentException("El número debe ser distinto de null");
            else
                return CalcularFibonacci(n);
           // throw new ArgumentException("Debe ingresar un parámetro a la vez");
        }

        public int CalcularFibonacci(params string[] s)
        {
            throw new ArgumentException("Debe ingresar un parámetro valor númerico");
        }
        public List<int> CalcularFibonacci(params int[] numeros)
        {
            throw new ArgumentException("Este método solo acepta un parámetro a la vez");
        }
        public List<int> CalcularFibonacci(params double [] numeros)
        {
            throw new ArgumentException("El tipo de dato decimal no es válido para el cálculo de Fibonacci.");
        }

        public List<int> CalcularFibonacci(params long[] numeros)
        {
            throw new ArgumentException("El tipo de dato long no es válido para el cálculo de Fibonacci.");
        }
        public List<int> CalcularFibonacci(params float[] numeros)
        {
            throw new ArgumentException("El tipo de dato float no es válido para el cálculo de Fibonacci.");
        }
    }
}
