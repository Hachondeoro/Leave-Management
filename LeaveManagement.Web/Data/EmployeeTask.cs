using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data;

public class EmployeeTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    [Display(Name = "Assignee")] public string AssigneeId { get; set; }
    [Display(Name = "Assigner")] public string AssignerId { get; set; }
    [Display(Name = "Start Date")] public DateTime? StartDate { get; set; }
    [Display(Name = "Due Date")] public DateTime? DueDate { get; set; }
    public string? Status { get; set; }
    public virtual Employee? Assignee { get; set; }
    public virtual Employee? Assigner { get; set; }
}