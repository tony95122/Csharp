using System;
// Define um namespace para organizar o código
namespace ExemploVariaveis
{
    // A classe principal onde a execução do programa começa
    class Program
    {
        // O método Main é o ponto de entrada da aplicação
        static void Main(string[] args)
        {
            // ----------------------------------------------------
            // 1. Tipos de Dados Inteiros (Números sem casas decimais)
            // ----------------------------------------------------

            // int: O tipo inteiro mais comum, usado para a maioria das contagens.
            int idade = 30;
            Console.WriteLine($"1. int (Inteiro): Idade = {idade}");
            
            // long: Usado para números inteiros muito grandes.
            long populacaoMundial = 8000000000L; // O 'L' indica que é um long
            Console.WriteLine($"2. long (Inteiro Grande): População Mundial = {populacaoMundial}");

            // ----------------------------------------------------
            // 2. Tipos de Dados de Ponto Flutuante (Números com casas decimais)
            // ----------------------------------------------------

            // double: O tipo de ponto flutuante mais comum, oferece alta precisão.
            double altura = 1.75;
            Console.WriteLine($"3. double (Decimal): Altura = {altura} metros");

            // float: Usado quando a precisão não é tão crítica, exige o sufixo 'f'.
            float preco = 19.99f; 
            Console.WriteLine($"4. float (Decimal Menos Preciso): Preço = R${preco}");

            // decimal: Usado para cálculos financeiros, exige o sufixo 'm' e oferece a maior precisão.
            decimal saldoBancario = 1500.75m;
            Console.WriteLine($"5. decimal (Financeiro): Saldo = R${saldoBancario}");

            // ----------------------------------------------------
            // 3. Tipos de Dados Texto e Caractere
            // ----------------------------------------------------

            // string: Uma sequência de caracteres (texto). Deve ser definida com aspas duplas.
            string nomeCompleto = "Maria da Silva";
            Console.WriteLine($"6. string (Texto): Nome = {nomeCompleto}");

            // char: Armazena um único caractere. Deve ser definida com aspas simples.
            char primeiraLetra = 'M';
            Console.WriteLine($"7. char (Caractere): Primeira Letra = {primeiraLetra}");

            // ----------------------------------------------------
            // 4. Tipo de Dados Booleano (Lógico)
            // ----------------------------------------------------

            // bool: Armazena um valor de verdadeiro (true) ou falso (false).
            bool estaLogado = true;
            Console.WriteLine($"8. bool (Lógico): Está Logado = {estaLogado}");

            // ----------------------------------------------------
            // 5. Tipo implícito (var)
            // ----------------------------------------------------

            // var: O C# infere o tipo da variável no momento da compilação.
            var valorInferencia = 500; // Será um 'int'
            Console.WriteLine($"9. var (Inferido): Valor = {valorInferencia} (Tipo: {valorInferencia.GetType().Name})");

            // Pausa a execução para que a saída seja visível (apenas em alguns ambientes)
            Console.ReadKey();
        }
    }
}