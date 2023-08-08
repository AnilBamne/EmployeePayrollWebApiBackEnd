using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Model
{
    public class EmpModel
    {
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsTrash { get; set; }
    }
}
