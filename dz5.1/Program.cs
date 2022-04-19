using System;

namespace dz5._1
{

    /*
    Пользователь вводит в консольном приложении длинное предложение. Каждое слово в этом предложении отделено одним пробелом. 
    Необходимо создать метод, который в качестве входного параметра принимает строковую переменную, а в качестве возвращаемого значения — массив слов. 
    После вызова данного метода программа вызывает второй метод, который выводит каждое слово в отдельной строке.
    
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            string[] words = StringSplit(sentence);
            Console.WriteLine("Слова предложения: ");
            WordsOutput(words);
        }
        /// <summary>
        /// Принимает введенную строку
        /// Делит строку на слова
        /// Возвращает массив строк (слов)
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        static private string[] StringSplit(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words;
        }
        /// <summary>
        /// Принимает массив строк (слов)
        /// Поэлементно выводит массив на экран
        /// </summary>
        /// <param name="words"></param>
        static private void WordsOutput(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
