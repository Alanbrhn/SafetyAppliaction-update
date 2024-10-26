﻿using SafetyAppliaction.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyApplication.Models
{
    //public class Employee
    //{
    //    [Key]
    //    public int EmployeeId { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string EmployeeName { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [ForeignKey("Department")]
    //    public int DepartmentId { get; set; }

    //    public bool IsActive { get; set; }

    //    [Required]
    //    public DateTime CreatedAt { get; set; }

    //    [Required]
    //    public DateTime UpdatedAt { get; set; }

    //    // Navigation properties
    //    public Department Department { get; set; }
    //    public ICollection<ApprovalWorkflow> ApprovalWorkflows { get; set; }
    //}
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }

        // Relasi ke Department
        public int DepartmentId { get; set; }
        public Departement Departements { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
