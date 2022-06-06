using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public Human()
        {
            TotalCount++;
        }
        public static int TotalCount;
        private string _name;
        public byte Age;

        public string Name
        {
            get => _name;
            set{
                if (CheckName(value))
                    _name = value;
            }
        }

        public static bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length>2)
            {
                if (Char.IsUpper(name[0]))
                {
                    for (int i = 1; i < name.Length; i++)
                    {
                        if (!Char.IsLower(name[i]))
                            return false;
                    }
                    return true;
                }
            }

            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name}  - Age: {this.Age}");
        }
    }
}
