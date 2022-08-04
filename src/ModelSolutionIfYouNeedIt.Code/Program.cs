using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> snowPloughNames = new List<string>();
            //Kludge to make unit tests work. They run using a different folder hierarchy. 
            if (args.Length == 1)
                //Code is being invoked from a unit test
                snowPloughNames = GetSnowPloughs(snowPloughNames, "");
            else
                //Code is running "normally"
                snowPloughNames = GetSnowPloughs(snowPloughNames, "LINQANDLAMBDACHALLENGE.CODE\\");

            //Your Challenge Code goes here:
            List<string> gritters = (from truck in snowPloughNames
                                     where truck.ToUpper().StartsWith("G")
                                     select truck).ToList<string>();

            List<string> gritters2 = snowPloughNames.Where(s => s.ToUpper().StartsWith("G")).ToList<string>();

            Console.WriteLine("Gritters that start with an 'G'");
            gritters.ForEach(t => Console.WriteLine(t));
            Console.WriteLine();

            Console.WriteLine("Gritters whose names are made up of only 2 words one of which contains the word 'snow'");
            List<string> snowGritters = (from truck in snowPloughNames
                        where (truck.ToUpper().Contains("SNOW")
                        && truck.Split(" ").Count() == 2)
                        select truck).ToList<string>();

            List<string> snowGritters2 = snowPloughNames.Where(t => t.ToUpper().Contains("SNOW") && t.Split(" ").Count() == 2).ToList();
            snowGritters.ForEach(sg => Console.WriteLine(sg));

            Console.WriteLine();
        }

        private static List<string> GetSnowPloughs(List<string> snowPloughNames, string pathStart)
        {
            try{
                string filePath = pathStart + "ScottishSnowPloughs.txt";
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string snowPlough;
                        while ((snowPlough = reader.ReadLine()) != null)
                        {
                            snowPloughNames.Add(snowPlough);
                        }
                    }
                }
            }
            catch(Exception exn){
                Console.WriteLine(exn.Message);
            }
            return snowPloughNames;
        }
    }
}
