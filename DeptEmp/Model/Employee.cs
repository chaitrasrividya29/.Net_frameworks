using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeptEmp.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }

        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }

        // Navigation property - each employee belongs to one department
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

    }
}
