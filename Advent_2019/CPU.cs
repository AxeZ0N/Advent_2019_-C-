using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_2019
{
    class CPU
    {
        private ArrayList memory;
        private int instructionPointer;

        public ArrayList getMemory()
        {
            return this.memory;
        }

        public int getInstructionPointer()
        {
            return instructionPointer;
        }

        public int setInstructionPointer(int i)
        {
            instructionPointer = i;
            return instructionPointer;
        }

        public ArrayList setMemory(ArrayList memory)
        {
            this.memory = memory;

            return this.memory;
        }

        public ArrayList initMemory(string path)
        {
           return setMemory(getFromFile(path));

        }

        private ArrayList getFromFile(string path)
        {
            ArrayList arrayList = new ArrayList();

            if (File.Exists(path))
            {
                string[] array = File.ReadAllLines(path);
                string[] splitArray = array[0].Split(",");

                arrayList.AddRange(splitArray);

                return arrayList;

            } else
            {
                return null;
            }
        }

        public CPU()
        {
            memory = new ArrayList();
            instructionPointer = 0;
        }


        public String selectCode(int pos)
        {
            var memAtPos = memory[pos];

            switch (memAtPos)
            {

                case "1":
                    {
                        return add(pos);
                    }
                case "2":
                    {
                        return mult(pos);
                    }

                case "99":
                    {
                        return memAtPos.ToString();
                    }
                default:
                    {
                        throw new NotSupportedException("The following intcode is not supported:" + memAtPos);
                    }

            }
        }

        private string mult(int pos)
        {

            int memAtPos = (int)memory[pos];
            int firstArg = (int)memory[pos + 1];

            return firstArg.ToString();
            
        }

        private string add(int pos)
        {
            int memAtPos = (int)memory[pos];
            int firstArg = (int)memory[pos + 1];

            return firstArg.ToString();
        }
    }
}
