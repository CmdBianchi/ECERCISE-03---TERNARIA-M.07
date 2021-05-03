using System;
namespace ECERCISE_03___TERNARIA_M._07 {
    class Program {
        static void Main(string[] args) {
            double preco = 34.5;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(+preco);
        }
    }
}
