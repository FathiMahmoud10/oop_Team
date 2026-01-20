using OOP_Pro.Classes;
using OOP_Pro.Models;

namespace OOP_Pro
{
    internal class Program
    {
        
        
        /* Added by Fathi 
             
             بيدخل اللي اسمة TextReading 
            و بيرجع بالبيانات الموجوده في الملف 
            و بيخزنها في Arry 

             */
        static void Main(string[] args)
        {
            Student[] students = TextReading.ReadStudentsFromFile("students.txt");

            Console.WriteLine($"All Students");



            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} - {s.Course} - Grade: {s.Grade}");
            }


            Console.WriteLine($"\n");


            if (students != null)
            {
                StudentOrgnize.StudentAnalyze(students);
            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }
    }
}
