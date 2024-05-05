using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data;

public class Employee : IdentityUser
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? TaxId { get; set; }
    public string? EmploymentType { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateJoined { get; set; }
    public virtual ICollection<EmployeeTask>? EmployeeTasksAssigned { get; set; }
    public virtual ICollection<EmployeeTask>? EmployeeTasksAssignedBy { get; set; }
    public virtual ICollection<Expense>? ExpensesRecorded { get; set; }
}