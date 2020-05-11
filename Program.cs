using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------------------
            //1)

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            //where
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
            }
            //orderby

            //select

            //-------------------------------------------------------------------------------------------------------------
            //2)

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            var removeDuplicates = names.Where(n => n.());
            foreach (var name in removeDuplicates)
            {
                Console.WriteLine(removeDuplicates);
            }


            //-------------------------------------------------------------------------------------------------------------
            //3)
             List<string> classGrades = new List<string>() {"80,100,92,89,65","93,81,78,84,69","73,88,83,99,64","98,100,66,74,55"};



        }
    }
}
