namespace LeaveManagement.Web.Data;

public class EmployeeTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string AssigneeId { get; set; }
    public string AssignerId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Status { get; set; }
}