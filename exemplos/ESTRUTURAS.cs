using System;

// Adicionado o namespace CORRETO que corresponde à sua pasta 'exemplos'
namespace chsharp.exemplos 
{
    public class VerificadorDeNumero
    {
        // Método padronizado para ser chamado pelo Program.cs
        public static void ExecutarEstruturas() 
        {
            Console.WriteLine("\n--- Demonstração de Estruturas Condicionais (if/else) ---");
            
            // 1. Declara e inicializa uma variável inteira
            int numero = 15; 

            // 2. Início da estrutura condicional
            if (numero >= 10) 
            {
                // 3. Bloco de código executado SE a condição for verdadeira
                Console.WriteLine("O número é 10 ou maior."); 
            }
            else 
            {
                // 4. Bloco de código executado SE a condição for falsa
                Console.WriteLine("O número é menor que 10."); 
            }

            // 5. Linha final para manter o console aberto (Removido daqui, deve ficar APENAS no Program.cs)
        }
    }
}