/*Задание: Разработка консольного приложения для анализа текста
Описание задания:
Вашей задачей является разработка консольного приложения на платформе C#,
которое проводит анализ текста на основе различных параметров, таких как
частота использования слов, длина предложений, и т.д.
Шаги:
1 Ввод и обработка текста: Разработайте функцию для ввода текста с консоли.
Обработайте введенный текст, убирая из него специальные символы и знаки
препинания.
2 Анализ частоты слов: Реализуйте функцию, которая анализирует частоту
использования каждого слова в тексте. Выведите наиболее часто
встречающиеся слова.
3 Анализ длины предложений: Разработайте функцию, которая анализирует
среднюю длину предложений в тексте. Выведите результат.
4 Определение наиболее часто встречающихся символов: Напишите код,
который определяет, какие символы встречаются чаще всего в тексте.
5 Анализ уникальных слов: Разработайте функцию, которая определяет
количество уникальных слов в тексте.
6 Создание отчета: На основе анализа, создайте отчет, который включает в себя
статистику по каждому из параметров.
7 Рефакторинг кода: Проведите рефакторинг вашего кода с целью улучшения
читаемости и эффективности.
8 Тестирование: Проведите тестирование приложения, включая ввод различных
видов текстов для анализа.
9 Документация и отчет: Создайте подробную документацию о разработанном
приложении, включая описание его функционала и инструкцию по запуску.
Это задание позволяет студентам применить знания по работе с текстом,
анализу данных и структурам данных в реальной задаче.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для анализа:");
            string text = Console.ReadLine();
            text = CleanText(text);
            Console.WriteLine();
            Console.WriteLine("текст с убранными из него специальными символами и знаками nрепинания.");
            Console.WriteLine(text);

            Dictionary<string, int> wordFreq = GetWordFrequency(text);
            Console.WriteLine();
            Console.WriteLine("Наиболее часто встречающиеся слова:");
            PrintTopWords(wordFreq, 10);

            double avgSentenceLength = GetAverageSentenceLength(text); 
            Console.WriteLine();
            Console.WriteLine($"Средняя длина предложений: {avgSentenceLength - 1} слов");

            Dictionary<char, int> charFreq = GetCharFrequency(text);
            Console.WriteLine();
            Console.WriteLine("Наиболее часто встречающиеся символы:");
            PrintTopChars(charFreq, 10);

            int uniqueWords = GetUniqueWordsCount(wordFreq);
            Console.WriteLine();
            Console.WriteLine($"Количество уникальных слов: {uniqueWords}");

            //  string report = GenerateReport(text, wordFreq, avgSentenceLength, charFreq, uniqueWords); // Создаем отчет на основе анализа
            //Console.WriteLine("Отчет по анализу текста:");
            //Console.WriteLine(report);

        }

        static string CleanText(string text)
        {
            text = text.ToLower();
            text = Regex.Replace(text, @"[^\w\s\.]", ""); 
            return text;
        }

        static Dictionary<string, int> GetWordFrequency(string text)
        {
            Dictionary<string, int> wordFreq = new Dictionary<string, int>(); 
            string[] words = text.Split();
            foreach (string word in words) 
            {
                if (word != ".")
                {
                    if (wordFreq.ContainsKey(word))
                    {
                        wordFreq[word]++; 
                    }
                    else
                    {
                        wordFreq[word] = 1; 
                    }
                }
            }
            return wordFreq;
        }

       
        static void PrintTopWords(Dictionary<string, int> wordFreq, int n)
        {
            var sortedWordFreq = from pair in wordFreq
                                 orderby pair.Value descending
                                 select pair;
            int i = 0;
            foreach (var pair in sortedWordFreq)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
                i++;
                if (i == n) break;
            }
        }

        
        static double GetAverageSentenceLength(string text)
        {
            string[] sentences = text.Split('.');
            int sentenceCount = sentences.Length - 1;
            int wordCount = 0;
            foreach (string sentence in sentences) 
            {
                string[] words = sentence.Split();
                wordCount += words.Length; 
            }
            double avgSentenceLength = (double)wordCount / sentenceCount; 
            return avgSentenceLength; 
        }

        
        static Dictionary<char, int> GetCharFrequency(string text)
        {
            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            foreach (char c in text) 
            {
                if (c != ' ' && c != '.') 
                {
                    if (charFreq.ContainsKey(c)) 
                    {
                        charFreq[c]++;
                    }
                    else 
                    {
                        charFreq[c] = 1;
                    }
                }
            }
            return charFreq;
        }

    
        static void PrintTopChars(Dictionary<char, int> charFreq, int n)
        {
            
            var sortedCharFreq = from pair in charFreq
                                 orderby pair.Value descending
                                 select pair;
           
            int i = 0;
            foreach (var pair in sortedCharFreq)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
                i++;
                if (i == n) break;
            }
        }

        
        static int GetUniqueWordsCount(Dictionary<string, int> wordFreq)
        {
            return wordFreq.Count;
        }

       
        static string GenerateReport(string text, Dictionary<string, int> wordFreq, double avgSentenceLength, Dictionary<char, int> charFreq, int uniqueWords)
        {
            string report = ""; 

            report += "Текст для анализа:\n"; 
            report += text + "\n\n"; 

            report += "Анализ частоты слов:\n"; 
            report += "Слово: Частота\n";
            foreach (var pair in wordFreq) 
            {
                report += $"{pair.Key}: {pair.Value}\n"; 
            }
            report += "\n"; 

            report += "Анализ длины предложений:\n"; 
            report += $"Средняя длина предложений: {avgSentenceLength} слов\n\n";

            report += "Анализ наиболее часто встречающихся символов:\n"; 
            report += "Символ: Частота\n";
            foreach (var pair in charFreq) 
            {
                report += $"{pair.Key}: {pair.Value}\n"; 
            }
            report += "\n"; 

            report += "Анализ уникальных слов:\n"; 
            report += $"Количество уникальных слов: {uniqueWords}\n\n"; 

            return report; 
        }
    }
}