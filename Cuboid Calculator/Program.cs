using System;
using System.Collections.Generic;
namespace Cuboid_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float volume, surfaceArea;
            var dic = new Dictionary<string, float>(){
                {"depth", 0.0f},
                {"width", 0.0f},
                {"height", 0.0f},
            };
            foreach ((string key, float value) in dic)
            {
                dic[key] = GetInput($"Enter {key}"); 
            }
            volume = dic["depth"] * dic["width"] * dic["height"];
            surfaceArea = 2 * (dic["depth"] * dic["width"]) + 2 * (dic["width"] * dic["height"]) + 2 * (dic["depth"] * dic["height"]);
            Console.WriteLine(volume);
            Console.WriteLine(surfaceArea);
        }
        static float GetInput(string inputMessage)
        {
            float rawInput = 0.0f;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                try
                {
                    rawInput = float.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input, try again");
                }
            }
            return rawInput;
        }
    }
}
