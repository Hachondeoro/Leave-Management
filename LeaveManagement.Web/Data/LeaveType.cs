namespace LeaveManagement.Web.Data;

public class LeaveType
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}