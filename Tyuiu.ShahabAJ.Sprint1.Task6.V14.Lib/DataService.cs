using System;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShahabAJ.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            // Проверка на пустую строку
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            // Проверка, что все символы - строчные русские буквы
            foreach (char c in value)
            {
                if (!(c >= 'а' && c <= 'я') && c != 'ё')
                {
                    return false;
                }
            }

            return true;
        }
    }
}