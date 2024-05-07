using static System.Console;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using static System.IO.File;
using System.Windows;
class Program
{
    static void Main()
    {
        try
        {
            bool l = true, r = false;
            string filePath = string.Empty;
            string text = string.Empty;
            string target = string.Empty;
            uint targetEntriesCount = 0;
            WriteLine("Press any key..");
            var key = ConsoleKey.S;
            while (key != ConsoleKey.Enter)
            {
                key = ReadKey(true).Key;
                if (key == ConsoleKey.LeftArrow)
                {
                    l = true;
                    r = false;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    l = false;
                    r = true;
                }
                Clear();
                WriteLine("Выбрать файл?");
                if (l)
                {
                    BackgroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    BackgroundColor = ConsoleColor.Gray;
                }
                ForegroundColor = ConsoleColor.Black;
                Write(" da ");
                ResetColor();
                Write("  ");
                ResetColor();
                if (r)
                {
                    BackgroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    BackgroundColor = ConsoleColor.Gray;
                }
                ForegroundColor = ConsoleColor.Black;
                Write(" net ");
                ResetColor();
            }
            Clear();
            ResetColor();
            if (l)
            {
                WriteLine("Впешите путь к файлу\n(если он находится в корневой папке exe файла, напишите название)");
                filePath = ReadLine();
                try
                {
                    text = ReadAllText(filePath);
                    WriteLine("Файл успешно выбран.");
                    WriteLine(text);
                }
                catch
                {
                    throw new Exception("Файл не найден.");
                }
            }
            else if (r)
            {
                WriteLine("Введите текст:");
                text = ReadLine();
            }
            else
            {
                throw new Exception("Непредвиденный сценарий");
            }

            WriteLine("Введите слово для поиска:");
            target = ReadLine().ToLower();

            targetEntriesCount = CountWordOccurrences(text.ToLower(), target);
            WriteLine($"Были найдены {targetEntriesCount} вхождений слова \"{target}\".");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
    static uint CountWordOccurrences(string text, string word)
    {
        var words = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '"', '\'', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        uint count = (uint)words.Count(w => w.ToLower() == word.ToLower());
        return count;
    }
}
