
# 📝 TextEditor Console App

Um editor de texto simples feito em C# para rodar diretamente no terminal. Com esta aplicação, você pode **criar**, **editar**, **visualizar** e **salvar arquivos `.txt` ou `.md`** diretamente pela linha de comando.

Este projeto é ideal para quem está aprendendo C# e deseja entender melhor o uso de estruturas como `switch`, `while`, leitura e escrita de arquivos (`StreamReader`, `StreamWriter`) e manipulação básica de strings.

## 🚀 Funcionalidades

- 📂 Abrir e visualizar arquivos de texto existentes
- ✍️ Digitar e editar um novo texto
- 💾 Salvar arquivos com nome e extensão personalizada
- 🔁 Retorna ao menu após cada operação
- 🧠 Prática de lógica de programação e manipulação de arquivos

## 📦 Como usar

### 1. Clone o repositório

```bash
git clone https://github.com/Pedro-2077/TextEditor.git
cd TextEditor
```

### 2. Compile e execute

Se estiver usando o .NET CLI:

```bash
dotnet build
dotnet run
```

Ou, se estiver usando Visual Studio, basta abrir o projeto `.csproj` e pressionar **F5**.

### 3. Utilize o menu

Quando a aplicação iniciar, você verá:

```
O que você deseja fazer?
1 - Abrir novo arquivo
2 - Criar arquivo novo
3 - Sair
```

* **Opção 1**: digite o caminho de um arquivo existente para abrir e visualizar seu conteúdo.
* **Opção 2**: digite livremente seu texto. Digite `/sair` em uma nova linha para finalizar e então escolha onde salvar.
* **Opção 3**: encerra o programa.

## 🧠 O que você aprende com este projeto

* Leitura e escrita de arquivos com `StreamReader` e `StreamWriter`
* Controle de fluxo com `switch`, `while` e `if`
* Uso de `Console.ReadLine()` e `Console.WriteLine()`
* Manipulação de strings e caminhos de arquivos
* Estruturação de métodos e menu interativo no terminal

## 📁 Estrutura

```
TextEditor/
├── Program.cs
└── README.md
```

## ✅ Requisitos

* [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
* Terminal ou prompt de comando

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

Desenvolvido com 💻 por [Pedro V.](https://github.com/Pedro-2077)

