using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookSystem
{
    internal class PhoneBook
    {
        private int Size;
        private string[] Name;
        private int[] Number;

        public PhoneBook(int size)
        {
            Size = size;
            Name = new string[Size];
            Number = new int[Size];
        }

        public void addEntry(int index, string name, int number)
        {
            if (index >= 0 && index < Size)
            {
                Name[index] = name;
                Number[index] = number;
                Console.WriteLine($"{name} - {number}");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }

        public void getRecord(string name)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == name)
                {
                    Console.WriteLine($"{Name[i]}: {Number[i]}");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }

    }
}
