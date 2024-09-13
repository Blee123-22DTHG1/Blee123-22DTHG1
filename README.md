//Le Quoc Binh
//22DTHG1


using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nhap thong tin cho hoc sinh thu {i + 1}:");

                Console.Write("Ma so hoc sinh: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Ten hoc sinh: ");
                string name = Console.ReadLine();

                Console.Write("Tuoi hoc sinh: ");
                int age = int.Parse(Console.ReadLine());

                students.Add(new Student { Id = id, Name = name, Age = age });
            }

            Console.WriteLine("\nDanh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nHoc sinh tuoi tu 15 đến 18:");
            var students1518 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in students1518)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nHoc sinh co ten bat dau bang 'A':");
            var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua hoc sinh: {totalAge}");

            var oldestStudent = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            Console.WriteLine("\nDanh sach tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.ReadKey();
        }
    }
}
