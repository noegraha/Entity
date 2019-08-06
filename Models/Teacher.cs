using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skills { get; set; }
        public int TotalStudents { get; set; }
        public decimal Salary { get; set; }
        public string AddedOn { get; set; }
        public string Address { get; set; }
        public string NoHp { get; set; }
        public DateTime? Tanggal { get; set; }
    }
}
