using System;
using chsharp.exemplos; // ESSENCIAL: Acessa todas as classes da pasta 'exemplos'

namespace chsharp
{
    // O ÚNICO local com o ponto de entrada (Main)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Iniciando a Orquestração do Projeto C# Organizado ---");
           
            // 1. Chamada do Hello World
            // Classe: DemonstracaoHelloWorld (Arquivo: demonstraçãohelloworld.cs)
            DemonstracaoHelloWorld.Executar();

            // 2. Chamada da Demonstração de Variáveis
            // Classe: Variavel (Arquivo: Variavel.cs)
            Variaveis.ExecutarVariaveis();

            // 3. Chamada da Demonstração de Funções
            // Classe: FuncoesBasicas (Arquivo: Funcoes.cs)
            FuncoesBasicas.ExecutarDemonstracao();

            // 4. Chamada da Demonstração de Loops
            // Classe: LoopsDemo (Arquivo: loops.cs)
            LoopsDemo.Executar();

            // 5. Chamada da Demonstração de Estruturas Condicionais
            // Classe: VerificadorDeNumero (Arquivo: ESTRUTURAS.cs)
            VerificadorDeNumero.ExecutarEstruturas();

            Console.WriteLine("\n--- Todas as Demonstrações Concluídas com Sucesso ---");
           
            // Linha final que mantém a janela do console aberta.
            Console.ReadKey();
        }
    }
}