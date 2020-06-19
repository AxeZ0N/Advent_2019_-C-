using System;
using System.IO;

namespace Advent_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\input.txt");

            path = @"C:\Users\Ryan\Desktop\advent01\input.txt";

            CPU cpu = new CPU();
            cpu.initMemory(path);

            Console.WriteLine(cpu.selectCode(cpu.getInstructionPointer()));




        }
    }
}
