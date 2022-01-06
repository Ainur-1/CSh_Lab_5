using System;

namespace CSh_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex_1();
            Ex_2();
        }
        static void Ex_1()
        {
            string text = "Язык программирования C#";
            string text1 = "";
            string text2 = "";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                text1 += words[i] + " ";
            }
            Console.WriteLine(text1);
            string[] words1 = text1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string letter in words1)
            {
                for (int i = letter.Length - 1; i >= 0; i--)
                {
                    text2 += letter[i];
                }
                text2 += " ";
            }
            Console.WriteLine(text2);
        }
        static void Ex_2()
        {
            //Ввод текста в консоль
            string str;
            Console.Write("Введите текст: ");
            str = Console.ReadLine();
            Console.WriteLine();

            //Выделение слов из текста
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words[words.Length - 1] = words[words.Length - 1].Substring(0, words[words.Length - 1].Length - 1);
            Console.WriteLine("Кол-во слов в тексте - " + words.Length);

            //Определение кол-ва букв в самом длинном слове
            int maxlenght = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 20)
                {
                    Console.WriteLine("Не соответствует условию, слова не должны содержать 20 символам");
                    break;
                }
                if (maxlenght <= words[i].Length)
                {
                    maxlenght = words[i].Length;
                }
            }
            Console.WriteLine("Кол-во букв в самом длинном слове - " + maxlenght);
            Console.WriteLine();

            //Вывод на экран зашифрованного текста.
            char[] str1 = str.ToCharArray();
            for (int i = 0; i < str1.Length; i++)
            {
                if ((int)str1[i] == 32 | (int)str1[i] == 44 | (int)str1[i] == 46)
                {
                    str1[i] = (char)(str1[i]);
                }
                else str1[i] = (char)(str1[i] + maxlenght);
                if (((90 < (int)str1[i]) & (97 > (int)str1[i])) | (122 < (int)str1[i]))
                {
                    str1[i] = (char)(str1[i] - 26);
                }
            }
            Console.WriteLine(str1);
        }
    }
}
