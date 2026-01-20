using OfficeOpenXml;
using OOP_Pro.Models;
using System;
using System.ComponentModel;
using System.IO;

namespace OOP_Pro.Classes
{
    static class TextReading
    {
        /*
الكلاس ده بيقرا البيانات الموجوده في ملف TEXT 
الملف بيكون محفوظ في ملف ال bin 
اسم الملف students.txt
بيقرا البيانات و بيحفظها في Arry

Features : 
load student data


By Fathi 
*/
        public static Student[] ReadStudentsFromExcel(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Excel file not found!");
                return new Student[0];
            }


            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Sheet1
                int rowCount = worksheet.Dimension.Rows;

                Student[] students = new Student[rowCount - 1];

                for (int row = 2; row <= rowCount; row++) // start after header
                {
                    students[row - 2] = new Student
                    {
                        Id = int.Parse(worksheet.Cells[row, 1].Text),
                        Name = worksheet.Cells[row, 2].Text,
                        Course = worksheet.Cells[row, 3].Text,
                        Grade = int.Parse(worksheet.Cells[row, 4].Text),
                        Attendance = int.Parse(worksheet.Cells[row, 5].Text)
                    };
                }

                return students;
            }
        }
    }
}
