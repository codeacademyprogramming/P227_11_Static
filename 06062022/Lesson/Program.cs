using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student
            {
                FullName = "Hikmet",
                GroupNo = "P123",
            };
            
            Student student2 = new Student
            {
                FullName = "Nezrin",
                GroupNo = "P123",
            };
            Student student3 = new Student
            {
                FullName = "Abbas",
                GroupNo = "P123",
            };

            Console.WriteLine(student3.No);
            Console.WriteLine("Total students: "+Student.TotalCount);



            Console.WriteLine("Say daxil et");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Human[] humans = new Human[count];

            for (int i = 0; i < count; i++)
            {
                string name;
                do
                {
                    Console.WriteLine("Ad:");
                    name = Console.ReadLine();

                } while (!Human.CheckName(name));
            }


            Console.WriteLine(Human.TotalCount);

        }
    }

}
