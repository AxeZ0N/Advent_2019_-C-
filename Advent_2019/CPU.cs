using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

        private string storeItemInMemory(int pos, string value)
        {
            memory[pos] = value;
            return memory[pos].ToString();
        }

        private int[] parseIntCode(int pos)
        {
            string baseOpCode = memory[pos].ToString();

            if(baseOpCode.Length < 5)
            {
                var pad = "0000";
                baseOpCode = pad + baseOpCode;
                baseOpCode.Substring(baseOpCode.Length - 5);
            }

            string[] 


            for (int i = 0; i < 5; i--)
            {


            }



        }


        private string mult(int[] numbersToUse)
        {

            int memAtPos = numbersToUse[0];
            int firstArg = numbersToUse[1];
            int secondtArg = numbersToUse[2];
            int thirdArg = numbersToUse[3];

            int finalVal = secondtArg * firstArg;

            storeItemInMemory(thirdArg, finalVal.ToString());

            return finalVal.ToString();
  
        }

        private string add(int[] numbersToUse)
        {

            int memAtPos = numbersToUse[0];
            int firstArg = numbersToUse[1];
            int secondtArg = numbersToUse[2];
            int thirdArg = numbersToUse[3];

            int finalVal = secondtArg + firstArg;

            storeItemInMemory(thirdArg, finalVal.ToString());

            return finalVal.ToString();

        }
    }
}
