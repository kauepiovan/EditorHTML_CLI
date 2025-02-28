using System;
using System.Drawing;

namespace EditorHtml 
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen(20, 60);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }

        public static void DrawScreen(int lines, int colums)
        {
            DrawLine(colums);
            DrawBlankSpaces(lines, colums);
            DrawLine(colums);
        }

        public static void DrawLine(int colums)
        {
            Console.Write("+");
            for (int i = 0 ; i <= colums ; i++)
                Console.Write("-");
            Console.Write("+");
        }

        public static void DrawBlankSpaces(int lines, int colums)
        {
            for (int i = 0 ; i <= lines ; i++)
            {
                Console.Write("\n|");
                for (int j = 0 ; j <= colums ; j ++)
                    Console.Write(" ");
                Console.Write("|");
            }
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(26, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(23, 3);
            Console.WriteLine("-----------------");
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("Selecione uma das opcoes abaixo:");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("2 - Abrir arquivo\n");
            Console.SetCursorPosition(15, 12);
            Console.WriteLine("0 - Sair\n\n");
            Console.SetCursorPosition(15, 14);
            Console.Write("Opcao: ");

        }

        public static void HandleMenuOptions(short option)
        {
            switch(option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                {
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}
