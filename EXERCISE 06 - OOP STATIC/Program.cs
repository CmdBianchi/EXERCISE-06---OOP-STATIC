using System;
namespace EXERCISE_06___OOP_STATIC{
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {      
        static void Main(string[] args) {
            Console.Write("Qual cotação do dólar? "); double price = double.Parse(Console.ReadLine());          
            Console.Write("Quantos dólares ira comprar? "); double amount = double.Parse(Console.ReadLine());
            double result = Converter.DolarToReal(amount, price);           
            Console.Write("Valor a ser pago em R$: " +result.ToString("F2"));
            Console.ReadLine();
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
