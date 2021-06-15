using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
           Double valorProduto;
           Double valorPago;
           Double troco;


            Console.WriteLine("================================================");
            Console.WriteLine("Olá, cliente! Qual é o seu nome: ");
            nome = (Console.ReadLine());


            Console.Write("Prazer " + nome + "! Vamos começar, Digite o valor do produto:  " );
            valorProduto = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Realize o pagamento: ");
                valorPago = Convert.ToDouble(Console.ReadLine());
                if (valorPago < valorProduto)
                {
                    Console.WriteLine(" O valor de pagamento é menor que o do produto.");
                    Console.WriteLine("===============================================");
                    Console.WriteLine(" Digite um valor válido:  ");
                    valorPago = Convert.ToDouble(Console.ReadLine()); 
                }
                if (valorPago > valorProduto)
                {
                    troco = valorPago - valorProduto;
                    Console.WriteLine("Seu troco: " + troco);
                    Console.WriteLine("================================================");
                    Console.WriteLine(" Obrigado por compra com a Forway!");
                }
                else if (valorPago == valorProduto)
                {
                    Console.WriteLine("Não há troco!");
                    Console.WriteLine("================================================");
                    Console.WriteLine(" Obrigado por compra com a Forway!");

                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }

}
