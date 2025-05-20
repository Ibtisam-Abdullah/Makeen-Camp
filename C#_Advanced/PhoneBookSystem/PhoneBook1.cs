using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookSystem
{
    internal class PhoneBook1
    {
        private int Size;
        private string[] Name;
        private int[] Number;

        public PhoneBook1(int size)
        {
            Size = size;
            Name = new string[Size];
            Number = new int[Size];
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (this.Name[i] == name)
                    {
                        return Number[i];
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] == name)
                    {
                        Number[i] = value; // update existing
                        return;
                    }
                }
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] == null)
                    {
                        Name[i] = name;
                        Number[i] = value;
                        return;
                    }
                }
                // If phone book is full
                Console.WriteLine("Phone book is full. Cannot add more entries.");
            }
        }

    }
}
