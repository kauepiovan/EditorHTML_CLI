<div align="center">
  <h1 align="center">📝 Editor HTML CLI</h1>
  <p align="center">
    <strong>Um editor e visualizador de HTML simples, direto no seu terminal.</strong>
  </p>
  <p align="center">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
    <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
    <img src="https://img.shields.io/badge/CLI-Terminal-black?style=for-the-badge&logo=windows-terminal&logoColor=white" alt="CLI" />
  </p>
</div>

<hr />

## 📖 Sobre o Projeto

O **Editor HTML CLI** é uma aplicação de console desenvolvida em **C#** que permite ao usuário criar, editar, visualizar e salvar arquivos de texto com marcações HTML rudimentares diretamente no terminal.

O projeto foi criado com o intuito de demonstrar manipulação da interface do console, leitura e escrita de arquivos (I/O) e o uso de **Expressões Regulares (Regex)** para processamento de strings em tempo real.

---

## 🚀 Funcionalidades

- **Menu Interativo**: Interface customizada desenhada diretamente no console, com menus, formatação e controle de rotas.
- **Modo Editor**: Permite digitação contínua de texto contendo quebras de linha até que a tecla explícita `ESC` seja acionada.
- **Modo Visualização**: Renderiza o texto digitado processando as *tags* HTML básicas. Por exemplo, os textos marcados com `<strong>` e `</strong>` são parseados e destacados em **azul** na visualização final.
- **Persistência de Dados**: Salva o conteúdo digitado no sistema de arquivos do computador de forma segura.
- **Abertura de Arquivos**: Capacidade de carregar arquivos externos para o *Viewer* embutido no terminal.

---

## 🛠️ Stack Tecnológica

| Tecnologia | Descrição |
| :--- | :--- |
| **[C# (C-Sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)** | Linguagem orientada a objetos forte e tipada. |
| **[.NET](https://dotnet.microsoft.com/)** | Plataforma e *runtime* modernos para a execução do app. |
| **System.IO** | Namespace para fluxo de leitura (`StreamReader`) e escrita (`StreamWriter`) em disco. |
| **System.Text.RegularExpressions** | Motor nativo de avaliação do *parser* usando Regex. |

---

## 🏗️ Como Executar o Projeto Localmente

Para rodar este projeto, será preciso o **.NET SDK** rodando em sua máquina.

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Passos de Instalação

```bash
# 1. Clone o repositório
git clone https://github.com/kauepiovan/EditorHTML_CLI.git

# 2. Acesse o diretório do projeto
cd EditorHTML_CLI

# 3. Execute a aplicação via CLI do .NET
dotnet run
```

---

## 🗂️ Estrutura da Arquitetura C#

A aplicação tem as responsabilidades isoladas de forma lógica e simples:

- `Program.cs`: Ponto de entrada (Entry Point) que inicializa o Menu.
- `Menu.cs`: Responsável por desenhar visualmente os limites da tela (`DrawScreen`, `DrawLine`) no Console utilizando laços de repetição tradicionais. Faz o redirecionamento prático entre Criar Arquivo, Abrir Arquivo e Sair.
- `Editor.cs`: Controla o fluxo de entrada de texto e de saída com armazenamento em arquivo externo.
- `Viewer.cs`: Atua como o motor de renderização. Ao invés do HTML puro, aplica lógica de substituição (*Regex.Split* e parsing de `<strong>`) alterando cores nativas do *prompt* pela classe `Console`.

---

## 👨‍💻 Avaliados por Tech Recruiters: O que observar?

Para recrutadores técnicos e analistas de seleção, este é um projeto CLI que traz fundamentos excelentes das APIs da Microsoft e ciência da computação prática:

1. **Gestão Segura de Recursos**: Emprego do `using block` perante implementações `IDisposable` (como `StreamReader` e `StreamWriter`), assegurando o fechamento adequado de handles do Sistema Operacional, e não permitindo memory leaks.
2. **Alta Performance em Manipulação de Strings**: Utiliza o pacote `StringBuilder` de `System.Text`, muito mais eficiente para loop de entrada do Console do que a concatenação tradicional de string, mantendo a performance de espaço e tempo da aplicação estáveis;
3. **Engine de Regex**: Desmontagem e lógica de parsing da string usando `new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>")`, extraindo dados complexos via busca de padrão léxico.
4. **Programação Clean e Separação de Rotas**: O Código não é acoplado dentro do `Main` estático. Classes e responsabilidades definidas.

Fique à vontade para checar o código nos arquivos base.

---
> Desenvolvido com ☕ e focado em engenharia de software base.
