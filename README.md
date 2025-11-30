# Csharp
# Bem-vindo ao Guia Inicial de C# 🚀

Este projeto foi desenvolvido por estudantes da disciplina de Introdução à Engenharia da Computação da UFRPE/UABJ (Marcos Mateus, Iohanna, Helena, Luísa, Raiane) serve como um "kit de boas-vindas" completo para quem está começando na linguagem C#

Neste repositório, você encontrará tudo o que um iniciante precisa saber para dar os primeiros passos com C#, desde a sua instalação até os conceitos de código essenciais.

---

## 🗺 Índice do Guia

* 1. 💡 Visão Geral do C#
    * 1.1. O que é C# (C Sharp)?
    * 1.2. Principais Áreas de Atuação
    * 1.3. Prós e Contras da Linguagem
* 2. 🛠 Configuração do Ambiente
    * 2.1. Como Baixar o .NET SDK (que inclui o C#)
    * 2.2. Como Instalar o .NET SDK na Sua Máquina
    * 2.3. Configurando o VS Code para C#
        * 2.3.1. Instalação das Extensões Necessárias
        * 2.3.2. Como Iniciar um Projeto Básico
* *3. 📝 Exemplos de Código Básico (/exemplos)*
    * 3.1. Olá Mundo (hello_world.cs) 
    * 3.2. Variáveis e Tipos (variaveis_e_tipos.cs) 
    * 3.3. Estruturas Condicionais (estruturas_condicionais.cs) 
    * 3.4. Laços de Repetição (Loops) (loops.cs) 
    * 3.5. Funções Básicas (funcoes_basicas.cs) 

---
## 1. 💡 Visão Geral do C#

### 1.1. O que é C# (C Sharp)?

C# (pronuncia-se "C Sharp") é uma *linguagem de programação* moderna, orientada a objetos e fortemente tipada. Foi desenvolvida pela Microsoft como parte da sua iniciativa .NET e é padronizada pela ECMA e ISO. É uma linguagem que combina a produtividade do Visual Basic com o poder do C++ e a sintaxe elegante do Java.

### 1.2. 🚀 Principais Áreas de Aplicação

* *Desenvolvimento Web:* Criação de aplicações web robustas usando ASP.NET Core.
* *Desenvolvimento Desktop:* Criação de aplicações nativas para Windows (Windows Forms, WPF).
* *Desenvolvimento Mobile:* Criação de aplicações para iOS e Android usando Xamarin/.NET MAUI.
* *Desenvolvimento de Jogos:* É a linguagem primária utilizada no motor de jogos Unity, um dos mais populares do mundo.
* *Serviços em Nuvem (Cloud Computing):* Criação de serviços e APIs no Microsoft Azure.

### 1.3. Prós e Contras da Linguagem

| Prós (Vantagens) | Contras (Desafios) |
| :--- | :--- |
| *Integrado ao Ecossistema .NET:* Grande conjunto de bibliotecas e frameworks robustos. | *Curva de Aprendizado:* O ecossistema .NET é vasto e pode ser complexo para iniciantes. |
| *Fortemente Tipada:* Ajuda a detectar erros de programação em tempo de compilação. | *Performance:* Embora tenha melhorado com o .NET Core/5+, em cenários muito específicos, pode ser menos performática que linguagens de nível mais baixo como C++. |
| *Gerenciamento Automático de Memória:* O Garbage Collector (Coletor de Lixo) simplifica a gestão de memória, evitando memory leaks. | *Foco em Plataformas Microsoft:* Apesar de ser open-source e multiplataforma, ainda tem um forte vínculo e otimização com o ambiente Windows/Azure. |
| *Comunidade Ativa e Suporte Microsoft* contínuo. | |

---

## 2. 🛠 Configuração do Ambiente

Como Baixar e Instalar C#
Para começar a programar em C#, você precisa instalar o .NET SDK (Software Development Kit), que é a plataforma que inclui o compilador, as bibliotecas e o tempo de execução necessários para criar e rodar aplicações em C#. Passo a Passo: Instalação do .NET SDK
O .NET é mantido pela Microsoft e é totalmente cross-platform (funciona no Windows, macOS e Linux).

1. Baixar o Instalador
Acesse a página oficial: Vá para o site oficial do .NET (dotnet.microsoft.com).
Escolha a Versão e Plataforma:
Recomendamos baixar a versão mais atualizada.
Selecione o link de download que corresponde ao seu sistema operacional (Windows, macOS ou Linux).

2. Instalação no Sistema Operacional
Windows e macOS
Execute o Instalador: Localize o arquivo que você baixou (geralmente um .exe ou .pkg) e dê um clique duplo para iniciar o assistente de instalação.
Siga o Assistente: Siga as etapas na tela. Na maioria dos casos, você pode aceitar as configurações padrão e clicar em "Instalar" ou "Next".
Aguarde: A instalação levará alguns minutos. Ao final, clique em "Concluir".


3. Verificar a Instalação
Após a instalação, é crucial verificar se o C# e o .NET foram configurados corretamente:
Abra o Terminal/Prompt de Comando: Abra o Terminal (macOS/Linux) ou Prompt de Comando/PowerShell (Windows).
Execute o Comando de Verificação: Digite o seguinte comando e pressione Enter:
Bash
dotnet --version
Resultado Esperado: Se a instalação foi bem-sucedida, o terminal deve exibir o número da versão do .NET SDK que você acabou de instalar.
Se a versão for exibida, o C# está pronto para ser usado na sua máquina! O próximo passo é configurar um ambiente de desenvolvimento como o VS Code para escrever o código.

aqui está um link de tutorial no YOUTUBE caso precise de um suporte: https://www.youtube.com/watch?v=jIwa5tT32oU


Certifique-se de escolher o .NET SDK (e não apenas o Runtime).

