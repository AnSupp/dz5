using System;

namespace dz5._2
{
    /*
    Пользователь вводит в программе длинное предложение. Каждое слово раздельно одним пробелом. 
    После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:

    первый метод разделяет слова в предложении;
    второй метод меняет эти слова местами (в обратной последовательности). 

    При этом важно учесть, что один метод вызывается внутри другого метода, 
    то есть в методе main вызывается метод cо следующей сигнатурой — ReversWords (string inputPhrase). 

    Внутри этого метода вызывается метод по разделению входной фразы на слова.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            
            Console.WriteLine("Слова предложения в обратном порядке: ");
            string[] revWords = ReversWords(sentence);
            
            ReversSentenceOutput(revWords);
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
        /// Принимает введенную строку
        /// Вызывает метод StringSplit для разделения строки на отдельные слова,
        /// Инвертирует, полученный из метода StringSplit массив строк (слов)
        /// Возвращает этот массив
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static private string[] ReversWords(string inputPhrase)
        {
           string[] words = StringSplit(inputPhrase);
           Array.Reverse(words);

           return words;
        }
        /// <summary>
        /// Принимает массив слов (в обратном порядке)
        /// Склеивает массив в строку, выводит на экран
        /// </summary>
        /// <param name="revWords"></param>
        static private void ReversSentenceOutput(string[] revWords)
        {
            string reversSentence = "";
            foreach (string word in revWords)
            {
                reversSentence += word + ' ';
            }
            Console.WriteLine(reversSentence);
        }
    }
}
