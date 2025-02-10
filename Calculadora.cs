//Página para "arquivar" os comandos utilizados
using System.Net.Http.Headers;

namespace Calculadora
{
    class Operacoes
    {
        // public diz respeito a privacidade do meu método, se outros poderão interagir com ele
        // static determina se preciso instanciar alguma classe antes
        // decimal é o tipo de retorno que o método irá realizar
        public static decimal ObterValor() 
        {
        repetir:
            Console.Write("Informar o valor: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido!");
                goto repetir;
            }
            else
            {
                return valor;
            }
        }

        public static void RealizarAdicao()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ADIÇÃO");
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();
            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {valor1 + valor2}");
        }

        public static void RealizarSubtracao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SUBTRAÇÃO");
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();
            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {valor1 - valor2}");
        }

        public static void RealizarMultiplicacao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MULTIPLCAÇÃO");
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();
            Console.WriteLine($"A divisão dos valores {valor1} e {valor2} é {valor1 * valor2}");
        }

        public static void RealizarDivisao()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DIVISÃO");
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 = Operacoes.ObterValor();
            Console.WriteLine($"A divisão dos valores {valor1} e {valor2} é {valor1 / valor2}");
        }
    }
}



