// Вставьте сюда финальное содержимое файла CaseAlternatorTask.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод

        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //var enc1255 = Encoding.GetEncoding(1255);
            //System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            //System.Console.InputEncoding = enc1255;
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            var newResult = result.Distinct().Reverse().ToList();
            return newResult;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            // TODO
            if (startIndex == word.Length)
            {
                char[] maybe = new char[word.Length];
                word.CopyTo(maybe, 0);
                result.Add(new string(maybe));
                //result.Add(String.Copy(doAnotherWords.ToString()));
                return;
            }
            if (!Char.IsNumber(word[startIndex]))
            {
                word.SetValue(char.ToUpper(word[startIndex]), startIndex);
                AlternateCharCases(word, startIndex + 1, result);
                //char.ToLower(word[startIndex]);
                word.SetValue(char.ToLower(word[startIndex]), startIndex);
                AlternateCharCases(word, startIndex + 1, result);
            }
            else AlternateCharCases(word, startIndex + 1, result);
        }
    }
}