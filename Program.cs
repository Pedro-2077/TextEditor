namespace TextEditor
{
    static class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque você deseja fazer?");
            Console.WriteLine("1 - Abrir novo arquivo");
            Console.WriteLine("2 - Criar arquivo novo");
            Console.WriteLine("3 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo que deseja abrir:");
            string filePath = Console.ReadLine();

            using (var file = new StreamReader(filePath))
            {
                //Le o conteúdo do arquivo até o final
                string content = file.ReadToEnd();
                Console.WriteLine(content);
            }
            Console.WriteLine("------------------------");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto abaixo (digite '/sair' em uma linha para finalizar):");
            Console.WriteLine("------------------------");
            string text = "";
            string line;

            while (true)
            {
                line = Console.ReadLine();
                if (line == "/sair")
                    break;
                text += line + Environment.NewLine;
            }

            Salvar(text);

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo? com o nome do arquivo.txt");
            string fileName = Console.ReadLine();

            // Verifica se o caminho termina com .txt, .md, etc.
            while (string.IsNullOrWhiteSpace(fileName) || Directory.Exists(fileName))
            {
                Console.WriteLine("Caminho inválido! Digite o caminho completo com o nome do arquivo e extensão:");
                fileName = Console.ReadLine();
            }

            using (var file = new StreamWriter(fileName))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {fileName} salvo com sucesso!");
            Menu();
        }
    }
}