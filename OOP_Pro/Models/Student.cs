using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pro.Models
{
    public class Student
    {
        public int Id { get; set; } // كود الطالب 
        public string? Name { get; set; } // اسم الطالب 
        public string? Course { get; set; } // اسم الكورس 
        public int Grade { get; set; } // الدرجة 
        public int Attendance { get; set; } // درجة لحضور 
    }
}
