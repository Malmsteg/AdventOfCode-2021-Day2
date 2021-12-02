using System;
using System.IO;
using System.Text;


namespace AdventOfCode_2021_Day2
{
    public static class Program
    {
        public static void Main()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string file = Path.Combine(currentDirectory, @"..\..\..\input.txt");
            string path = Path.GetFullPath(file);
            string[] text = File.ReadAllText(path).Split("\n");

            int depth = 0;
            int distance = 0;
            int aim = 0;

            for(int i = 0; i < text.Length; i++){
                string[] input = text[i].Split(' ');
                int amount = Convert.ToInt32(input[1]);
                switch(input[0]){
                    case "forward":
                    distance+=amount;
                    depth+= aim*amount;
                    break;
                    case "down":
                    // depth+=amount;
                    aim+=amount;
                    break;
                    case "up":
                    // depth-=amount;
                    aim-=amount;
                    break;
                    default:
                    break;
                }
            }
            Console.WriteLine(depth*distance);

        }
    }
}
