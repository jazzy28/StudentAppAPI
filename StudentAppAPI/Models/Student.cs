using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAppAPI.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
