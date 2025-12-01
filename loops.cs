using System;

namespace exemploloops
{
    // O ÚNICO local com o ponto de entrada (Main)
    public class loops
    {
            int contador = 1;            // Cria uma variável e coloca o valor 1 nela
        public static void exeloops()
        {

            while (contador <= 5)        // Enquanto 'contador' for menor ou igual a 5
            {
                Console.WriteLine(contador);  // Mostra o valor do contador na tela
                contador++;                   // Soma +1 ao contador
            }

            for (int i = 1; i <= 5; i++)   // Começa em 1, vai até 5, somando +1 por vez
            {
                Console.WriteLine(i);      // Imprime o valor de i
            } 
            string nome = "";                     // Cria uma variável vazia

            while (nome != "sair")                // Repete até a pessoa digitar "sair"
            {
                Console.Write("Digite um nome ou 'sair': ");
                nome = Console.ReadLine();        // Lê o texto que o usuário digitou
            }
        }
    }
}
