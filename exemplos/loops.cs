using System;

// Namespace CORRETO para a pasta 'exemplos'
namespace chsharp.exemplos 
{
    public class LoopsDemo // Renomeei para LoopsDemo para seguir o padrão
    {
        public static void Executar() // Renomeei o método para Executar para seguir o padrão
        {
            // O erro CS0120 foi corrigido movendo 'contador' para DENTRO do método static.
            int contador = 1; // Cria uma variável local e coloca o valor 1 nela

            Console.WriteLine("\n--- Demonstração de Loops: While ---");
            while (contador <= 5) // Enquanto 'contador' for menor ou igual a 5
            {
                Console.WriteLine(contador); // Mostra o valor do contador na tela
                contador++; // Soma +1 ao contador
            }

            Console.WriteLine("\n--- Demonstração de Loops: For ---");
            for (int i = 1; i <= 5; i++) // Começa em 1, vai até 5, somando +1 por vez
            {
                Console.WriteLine(i); // Imprime o valor de i
            }

            Console.WriteLine("\n--- Demonstração de Loops: While com Entrada do Usuário ---");
            string nome = ""; // Cria uma variável vazia

            while (nome != "sair") // Repete até a pessoa digitar "sair"
            {
                Console.Write("Digite um nome ou 'sair': ");
                nome = Console.ReadLine(); // Lê o texto que o usuário digitou
            }
        }
    }
}
