using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Assignment3._3
{
    enum MonthOfAdmission
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Student
    {
        public int StudentID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public MonthOfAdmission MonthOfAdmission { get; set; }
        public char Grade { get; set; }
    }
}
