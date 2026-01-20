using OfficeOpenXml;
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
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            Student[] students = TextReading.ReadStudentsFromExcel("Students.xlsx");

            if (students.Length == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("All Students\n");

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} - {s.Course} - Grade: {s.Grade}");
            }

            Console.WriteLine("\n");

            StudentOrgnize.StudentAnalyze(students);

            Console.ReadLine();
        }
    }
}
