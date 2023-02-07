using System;

namespace lab_4._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Зад 8
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите номер символа для удаления: ");
            int text_del = Convert.ToInt32(Console.ReadLine());
            text = text.Remove(text_del - 1, 1);
            Console.WriteLine(text);
            #endregion

            #region Зад 9
            Console.Write("\nВведите текст: ");
            string text2 = Console.ReadLine();
            Console.Write("Введите символ который хотите удалить: ");
            string char_del = Console.ReadLine();
            while(true)
            {
                if(text2.IndexOf(char_del) == -1)
                {
                    break;
                }
                else
                {
                    int index = text2.IndexOf(char_del);
                    text2 = text2.Remove(index, 1);
                }
            }
            Console.WriteLine(text2);

            #endregion

            #region Зад 10
            Console.Write("\nВведите текст: ");
            string text3 = Console.ReadLine();
            Console.Write("Введите символ который хотите вставить: ");
            string char_insert = Console.ReadLine();
            Console.Write("Введите позицию для этого символа: ");
            int pos_insert = Convert.ToInt32(Console.ReadLine());
            text3 = text3.Insert(pos_insert - 1, char_insert);
            Console.WriteLine(text3);
            #endregion

            #region Зад 11
            Console.Write("Введите текст: ");
            string text_11 = Console.ReadLine();
            bool check = true;
            for (int i = 0; i < text_11.Length / 2; i++)
            {
                if (text_11[i] == text_11[text_11.Length - 1 - i])
                    continue;
                else
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Слово является палиндромом");
            else
                Console.WriteLine("Слово не является палиндромом");
            #endregion

            #region Зад 12
            Console.Write("Введите текст: ");
            string text_12 = Console.ReadLine();
            string[] count = text_12.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Кол-во слов = {0}", count.Length);
            #endregion

            #region Зад 13
            Console.Write("Введите текст: ");
            string text_13 = Console.ReadLine();
            Console.Write("Введите текст, который ищете: ");
            string search = Console.ReadLine();
            Console.Write("Введите текст, который хотите вставить: ");
            string put = Console.ReadLine();
            if (text_13.IndexOf(search) != -1)
                text_13 = text_13.Replace(search, put);
            else
                Console.WriteLine("Введите текст, который ищете нет");
            Console.WriteLine("Результат: {0}", text_13);
            #endregion

            #region Зад 14
            Console.Write("Введите текст: ");
            string text_14 = Console.ReadLine();
            string[] rep = text_14.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] rep_buf = text_14.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < rep.Length - 1; i++)
            {
                text_14 = text_14.Replace(rep[i], rep_buf[i + 1]);
                text_14 = text_14.Replace(" " + rep[i + 1], " " + rep_buf[i]);
            }
            Console.WriteLine("Результат: {0}", text_14);
            #endregion

            #region Зад 15
            Console.Write("Введите текст: ");
            string text_15 = Console.ReadLine();
            string[] rep_15 = text_15.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count_15 = 0;
            for (int i = 0; i < rep_15.Length; i++)
            {
                if (rep_15[i][rep_15[i].Length - 1] == 'а' || rep_15[i][rep_15[i].Length - 1] == 'о' || rep_15[i][rep_15[i].Length - 1] == 'у' ||
                    rep_15[i][rep_15[i].Length - 1] == 'е' || rep_15[i][rep_15[i].Length - 1] == 'ы' || rep_15[i][rep_15[i].Length - 1] == 'и' ||
                    rep_15[i][rep_15[i].Length - 1] == 'е' || rep_15[i][rep_15[i].Length - 1] == 'э' || rep_15[i][rep_15[i].Length - 1] == 'ю' || rep_15[i][rep_15[i].Length - 1] == 'я')
                    count_15++;
            }
            Console.WriteLine("Кол-во гласных = {0}", count_15);
            #endregion
        }
    }
}
