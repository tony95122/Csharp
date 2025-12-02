using System;

// Define um namespace para organizar a aplicação
namespace chsharp.exemplos
{
    // A classe que contém os métodos
    public class FuncoesBasicas
    {
        // =========================================================
        // 1. Método Simples (void) - Não retorna valor e não tem parâmetros
        // =========================================================
        public static void Saudacao()
        {
            Console.WriteLine("--- Executando Saudacao() ---");
            Console.WriteLine("Olá! Esta é uma função simples que apenas executa uma ação.");
        }

        // =========================================================
        // 2. Método com Parâmetros (void) - Não retorna valor, mas aceita dados
        // =========================================================
        public static void SomarEImprimir(int num1, int num2)
        {
            Console.WriteLine("\n--- Executando SomarEImprimir() ---");
            int resultado = num1 + num2;
            Console.WriteLine($"A soma de {num1} + {num2} é igual a: {resultado}");
        }

        // =========================================================
        // 3. Método com Retorno (int) - Retorna um valor inteiro
        // =========================================================
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // =========================================================
        // 4. Método com Retorno (string) - Retorna um valor de texto
        // =========================================================
        public static string CriarMensagem(string nome)
        {
            return $"Mensagem gerada: Bem-vindo(a) ao C#, {nome}!";
        }


        // =========================================================
        // MÉTODO DE INÍCIO MODIFICADO (para evitar o erro CS0017)
        // =========================================================
        public static void ExecutarDemonstracao() // Renomeado de Main para ExecutarDemonstracao
        {
            Console.WriteLine("INÍCIO do Programa de Demonstração de Funções\n");

            // Chamada da Função 1
            Saudacao();

            // Chamada da Função 2
            SomarEImprimir(15, 7);
            
            // Chamada da Função 3
            int produto = Multiplicar(4, 6);
            Console.WriteLine("\n--- Executando Multiplicar() ---");
            Console.WriteLine($"O resultado da multiplicação (4 * 6) é: {produto}");
            
            // Chamada da Função 4
            string mensagemFinal = CriarMensagem("Ana");
            Console.WriteLine("\n--- Executando CriarMensagem() ---");
            Console.WriteLine(mensagemFinal);

            Console.WriteLine("\nFIM do Programa.");
            Console.ReadKey();
        }
    }
}