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
