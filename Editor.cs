
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do 
            {
                file.Append(Console.ReadLine());
                file.Append("\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Viewer.Show(file.ToString());
            Console.ReadLine();

            Save(file.ToString());
        }

        public static void Save(string _file)
        {
            var flag = true;
            var path = "C:/dev";

            while (flag)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Deseja salvar o arquivo ( S/N )");

                var opt = char.Parse(Console.ReadLine().ToString().ToUpper().Trim());
                if (opt == 'S') {
                    Console.WriteLine("Onde deseja Salvar? ");
                    path = Console.ReadLine().Trim();
                    using (var file = new StreamWriter(path))
                    {
                        file.Write(_file);
                    }
                    flag = false;
                }
                else if (opt == 'N') {
                    flag = false;
                }
            }
            Menu.Show();
        }
    }
}