using System;
using ExemploVariaveis; // Namespace para a classe Variavel (A ser verificado)
using ExemploFuncoes; // Namespace para a classe FuncoesBasicas

namespace chsharp
{
    // O ÚNICO local com o ponto de entrada (Main)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Iniciando a Orquestração do Projeto ---");
            
            // 1. Chamada do Hello World Simples
            Console.WriteLine("Hello World!");

            // 2. Chamada da Demonstração de Variáveis
            // CHAMADA CORRETA: Apenas o Nome da Classe e o Método
            Variavel.ExecutarVariaveis(); 

            // 3. Chamada da Demonstração de Funções
            // CHAMADA CORRETA: Apenas o Nome da Classe e o Método (sem repetir o namespace)
            FuncoesBasicas.ExecutarDemonstracao(); 

            Console.WriteLine("\n--- Todas as Demonstrações Concluídas ---");
            
            // Mantemos a pausa no final do Main
            Console.ReadKey();
        }
    }
}