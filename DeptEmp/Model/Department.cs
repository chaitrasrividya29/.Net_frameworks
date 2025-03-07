using System.ComponentModel.DataAnnotations;

namespace DeptEmp.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // Navigation property - one department has many employees
        public virtual ICollection<Employee> Employees { get; set; }
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

    }
}
