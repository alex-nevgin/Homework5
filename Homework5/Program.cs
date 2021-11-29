using System;

namespace Homework5
{
    internal class Program
    {
        /// <summary>
        /// Метод для разделения введённой строки на слова
        /// </summary>
        /// <param name="sent">Строка для разделения</param>
        /// <returns>Массив подстрок, который был получен из введённой строки</returns>
        static string[] SplitSentence(string sent)
        {
            string[] sentence = sent.Split(" "); // Массив подстрок, полученных при делении исходной строки

            for (int i = 0; i < sentence.Length; i++) // Заполняем массив
            {
                string subStr = sentence[i];
            }
            return sentence;
        }

        /// <summary>
        /// Метод для перестановки слов во введённом предложении
        /// </summary>
        /// <param name="sent"></param>
        /// <returns></returns>
        static string[] ReverseWording(string sent)
        {
            string[] sentence = SplitSentence(sent);
            Random random = new Random();
            for (int i = 0; i < sentence.Length; i++)
            {
                int j = random.Next(sentence.Length - 1);
                sentence[i] = sentence[j];
            }
            string[] revSent = sentence;
            return revSent;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для преобразования: ");
            string sent = Console.ReadLine();
            string[] sentence = SplitSentence(sent);
            Console.WriteLine($"Результат разделения: ");

            foreach (string s in sentence) // Перебор элементов массива подстрок для их вывода
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine($"Результат перестановки: " + ReverseWording(sent));
            
        }
    }
}
