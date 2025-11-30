using System;

namespace ExemploVariaveis // Este é o namespace do seu arquivo de variáveis
{
    // A classe DEVE ser 'public' para ser acessada pelo Program.cs
    public class Variavel 
    {
        // Renomeamos de Main para ExecutarVariaveis, e o tornamos 'public static'
        public static void ExecutarVariaveis() 
        {
            Console.WriteLine("\n--- Demonstração de Variáveis ---");

            // =========================================================
            //  INSIRA SEU CÓDIGO ORIGINAL DE VARIÁVEIS AQUI:
            // =========================================================
            
            int idade = 30;
            Console.WriteLine($"1. int (Inteiro): Idade = {idade}");
            
            long populacaoMundial = 8000000000L;
            Console.WriteLine($"2. long (Inteiro Grande): População Mundial = {populacaoMundial}");

            double altura = 1.75;
            Console.WriteLine($"3. double (Decimal): Altura = {altura} metros");

            float preco = 19.99f; // Exemplo do código original
            Console.WriteLine($"4. float (Decimal Menos Preciso): Preço = R${preco}");

            decimal saldoBancario = 1500.75m; // Exemplo do código original
            Console.WriteLine($"5. decimal (Financeiro): Saldo = R${saldoBancario}");

            string nomeCompleto = "Tony Silva";
            Console.WriteLine($"6. string (Texto): Nome = {nomeCompleto}");
            
            char primeiraLetra = 'T'; // Exemplo do código original
            Console.WriteLine($"7. char (Caractere): Primeira Letra = {primeiraLetra}");

            bool estaLogado = true; // Exemplo do código original
            Console.WriteLine($"8. bool (Lógico): Está Logado = {estaLogado}");

            var valorInferencia = 500; // Exemplo do código original
            Console.WriteLine($"9. var (Inferido): Valor = {valorInferencia} (Tipo: {valorInferencia.GetType().Name})");
            
            // =========================================================
            
        }
    }
}