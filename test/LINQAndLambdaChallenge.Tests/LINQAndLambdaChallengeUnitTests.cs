using System;
using Xunit;
using LINQAndLambda;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace SimpleConsoleAppTests
{
    public class LINQAndLambdaChallengeUnitTests
    {
        TextWriter m_normalOutput;
        StringWriter m_testingConsole;
        StringBuilder m_testingSB;

        //User input
        List<string> gritters = new List<string>();
        public LINQAndLambdaChallengeUnitTests()
        {
            // Set current folder to testing folder
            string assemblyCodeBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dirName = Path.GetDirectoryName(assemblyCodeBase);

            if (dirName.StartsWith("file:\\"))
                dirName = dirName.Substring(6);

            Environment.CurrentDirectory = dirName;

            m_testingSB = new StringBuilder();
            m_testingConsole = new StringWriter(m_testingSB);
            m_normalOutput = System.Console.Out;
            System.Console.SetOut(m_testingConsole);
        }

        [Fact]
        public void GrittersThatStartWithGTest()
        {
            //int i = 0;
            Assert.Equal(0, StartConsoleApplication());
            Assert.Contains(("Gangsta Granny Gritter\r\n" +
                            "Grit A Bit\r\n" +
                            "Grit Expectations\r\n" +
                            "Gritallica\r\n" +
                            "Gritney Spears\r\n" +
                            "Gritter Bug\r\n" +
                            "Grittest Hits\r\n" +
                            "Grittie McVittie\r\n" +
                            "Grittle Mix\r\n" +
                            "Gritty Gonzales\r\n" +
                            "Gritty Gritty Bang Bang").ToUpper(), m_testingSB.ToString().ToUpper());
        }


        [Fact]
        public void GrittersWhoseNamesAreMadeUpOfOnly2WordsOneOfWhichContainsTheWordSnowTest()
        {
            //int i = 0;
            Assert.Equal(0, StartConsoleApplication());
            Assert.Contains(("Amber Snowy\r\n" +
                            "Han Snow-Lo\r\n" +
                            "Luke Snowalker\r\n" +
                            "Snow Bother\r\n" +
                            "Snow Destroyer\r\n" +
                            "Snow Dozer\r\n" +
                            "Snow Trooper\r\n" +
                            "Snowbegone Kenobi\r\n" +
                            "Snowkemon Go").ToUpper(), m_testingSB.ToString().ToUpper());
        }

        private int StartConsoleApplication()
        {
            //Program.Main(arguments.Split(' '));
            Process proc = new Process();
            proc.StartInfo.FileName = "LINQAndLambdaChallenge.Code.exe";
            //Specifying "X" as an argument is part of a Kludge so the right filepath is used 
            //when reading the ScottishSnowPloughs.txt file.
            proc.StartInfo.Arguments = "X";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();
            proc.WaitForExit();
            System.Console.WriteLine(proc.StandardOutput.ReadToEnd());
            System.Console.Write(proc.StandardError.ReadToEnd());
            return proc.ExitCode;
        }
    }
}
