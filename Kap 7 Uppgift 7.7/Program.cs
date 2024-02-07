using System;
using System.Collections.Generic;
namespace Uppgift7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            string[] array1 = { "a","a", "b", "b", "c", "hej","fr" };
            string[] array2 = { "hej", "a", "a", "b", "programmering","fr" };
            string[] nyArray = FinnsIBåda(array1, array2);

            foreach (string str in nyArray)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// Jämför två arrayer och returnerar en ny array med alla strings som finns i de båda arrayerna. 
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns>En array</returns>
        static string[] FinnsIBåda(string[] array1, string[] array2)
        {
            List<string> teckenSomFinnsIBådaList = new List<string>();

            //Jämför de båda arrayerna.
            foreach (string s1 in array1)
            {
                if (teckenSomFinnsIBådaList.Contains(s1))
                {
                    continue;
                }

                foreach (string s2 in array2)
                {
                    if (s1 == s2)
                    {
                        teckenSomFinnsIBådaList.Add(s1);
                        break;
                    } 
                }
            }

            //Alla värden från listan kopieras till en array
            string[] teckenSomFinnsIBådaArray = new string[teckenSomFinnsIBådaList.Count()];
            for (int i = 0; i < teckenSomFinnsIBådaList.Count();i++)
            {
                teckenSomFinnsIBådaArray[i] = teckenSomFinnsIBådaList[i];
            }
            return teckenSomFinnsIBådaArray;
        }
    }
}
/*Skapa ett program som har en metod som heter FinnsIBåda. Metoden ska ha två
string-arrayer som parametrar. Metoden ska undersöka vilka strängar som finns i
båda arrayerna och returnera en ny array som innehåller dessa strängar. Varje sträng
ska endast förekomma en gång i den returnerade arrayen.
För testning så kan du använda följande info: om metoden anropas med de två
arrayerna
{ &quot;a&quot;, &quot;b&quot;, &quot;b&quot;, &quot;c&quot;, &quot;hej&quot; }
{ &quot;hej&quot;, &quot;a&quot;, &quot;a&quot;, &quot;b&quot;, &quot;programmering&quot; }
så ska den returnera
{ &quot;a&quot;, &quot;b&quot;, &quot;hej&quot; }*/