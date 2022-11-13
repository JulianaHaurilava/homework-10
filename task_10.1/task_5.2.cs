using System;


namespace task_5._2
{
    public class Sentence
    {
        /// <summary>
        /// Создает из строки массив слов
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Массив из слов предложения</returns>
        public static string[] ToArray(string str)
        {
            return str.Split(' ');
        }

        /// <summary>
        /// Меняет порядок слов в предложении на обратный
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Предложение с обратным порядком слов</returns>
        public static string ReverseSentence(string inputString)
        {
            string[] arrayOfWords = ToArray(inputString);
            Array.Reverse(arrayOfWords);
            return String.Join(' ', arrayOfWords);
        }
    }
}
